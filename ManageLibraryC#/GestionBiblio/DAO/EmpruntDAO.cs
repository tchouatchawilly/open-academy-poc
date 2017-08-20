using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using MySql.Data.MySqlClient;

namespace GestionBiblio.DAO
{
    class EmpruntDAO
    {
        GestionBiblio.ENTITY.Emprunt emprunt;

        internal GestionBiblio.ENTITY.Emprunt Emprunt
        {
            get { return emprunt; }
            set { emprunt = value; }
        }
        public EmpruntDAO(ENTITY.Emprunt emprunt)
        {
            this.emprunt = emprunt;
        }
        public EmpruntDAO()
        {
        }
        public bool ajouter(Emprunt emprunt)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteAjout = "insert into emprunt VALUES (?numempr, ?dateempr)";
                MySqlCommand cmd = new MySqlCommand(strRequeteAjout, con);
                defparametre(emprunt, cmd);

                //exécution de la commande
                cmd.CommandText = strRequeteAjout;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception ex)
            {
                throw new TOOLS.empruntException(1, emprunt);
            }
        }

        private static MySqlParameter defparametre(Emprunt emprunt, MySqlCommand cmd)
        {
            MySqlParameter param = new MySqlParameter();
            param.Value = emprunt.Numempr;
            param.ParameterName = "Numero emprunt";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = emprunt.Datempr;
            param.ParameterName = "Date emprunt";
            cmd.Parameters.Add(param);

            return param;
        }
        public bool Miseajour(Emprunt emprunt)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteMiseajour = "update emprunt set dateempr=?dateempr where numempr=?numempr";
                MySqlCommand cmd = new MySqlCommand(strRequeteMiseajour, con);

                defparametre(emprunt, cmd);

                //exécution de la commande
                cmd.CommandText = strRequeteMiseajour;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return false;
            }
        }
        public Emprunt getemprunt(string numempr)
        {
            try
            {
                Emprunt unemprunt = new Emprunt();
                MySqlConnection con = new Database().getconnection();
                string req = "select * from emprunt where numempr=?numempr";
                MySqlParameter param = new MySqlParameter();
                param.Value = numempr;
                MySqlCommand cmd = new MySqlCommand(req, con);
                param.ParameterName = "Numero emprunt";
                cmd.Parameters.Add(param);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                if (lecteur.HasRows)
                {
                    if (lecteur.Read())
                    {
                        unemprunt.Numempr = numempr;
                        unemprunt.Datempr = lecteur.GetDateTime("dateempr");
                        unemprunt.Lecteur.Numlect = lecteur.GetString("numlect");

                    }
                }
                else
                {
                    throw new Exception("Numero emprunt inexistant");
                }
                lecteur.Close();
                con.Close();
                return unemprunt;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return null;
            }

        }
        public static List<Emprunt> getListeEmprunt()
        {
            try
            {
                List<Emprunt> listeEmprunt = new List<Emprunt>();
                String req = "select numempr from emprunt";
                MySqlConnection con = new Database().getconnection();
                MySqlCommand cmd = new MySqlCommand(req, con);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                if (lecteur.HasRows)
                {
                    while (lecteur.Read())
                    {
                        string numempr = lecteur.GetString("numempr");
                        Emprunt unemprunt = new Emprunt();
                        listeEmprunt.Add(unemprunt);
                    }

                }
                lecteur.Close();
                con.Close();
                return listeEmprunt;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return null;
            }

        }
        public bool Suppr(string numempr)
        {
            try
            {


                //Insertion d'un etudiant dans la table etudiant
                //requetes parametrées
                MySqlConnection con = new Database().getconnection();
                string strRequeteSuppr = "delete from emprunt where numempr=?numempr";
                MySqlCommand cmd = new MySqlCommand(strRequeteSuppr, con);
                MySqlParameter param = new MySqlParameter();
                param.Value = numempr;
                param.ParameterName = "numempr";

                //exécution de la commande
                cmd.CommandText = strRequeteSuppr;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return false;
            }
        }
    }
}


