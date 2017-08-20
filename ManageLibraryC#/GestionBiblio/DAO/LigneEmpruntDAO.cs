using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using MySql.Data.MySqlClient;

namespace GestionBiblio.DAO
{
    class LigneEmpruntDAO
    {
        public bool ajouter(LigneEmprunt ligne)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteAjout = "insert into Ligneemprunt VALUES (?numempr,?numexpl, ?duree,?dateretour)";
                MySqlCommand cmd = new MySqlCommand(strRequeteAjout, con);
                defparametre(ligne, cmd);

                //exécution de la commande
                cmd.CommandText = strRequeteAjout;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception ex)
            {
                throw new TOOLS.LigneEmpruntException(1, ligne);
            }
        }

        private static MySqlParameter defparametre(LigneEmprunt ligne, MySqlCommand cmd)
        {
            Emprunt emp = new Emprunt();
            Exemplaire Exp = new Exemplaire();
            MySqlParameter param = new MySqlParameter();
            param.Value = emp.Numempr;
            param.ParameterName = "Numero emprunt";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = Exp.Numexpl;
            param.ParameterName = "Numero exemplaire";
            cmd.Parameters.Add(param);
            param.Value = ligne.Duree;
            param.ParameterName = "Duree emprunt";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = ligne.Dateretour;
            param.ParameterName = "Date retour exemplaire";
            cmd.Parameters.Add(param);

            return param;
        }
        public bool Miseajour(LigneEmprunt ligne)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteMiseajour = "update LigneEmprunt set duree=?duree,dateretour=?dateretour where numempr=?numempr,numexpl=?numexpl";
                MySqlCommand cmd = new MySqlCommand(strRequeteMiseajour, con);

                defparametre(ligne, cmd);

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
        public LigneEmprunt getligne(string numempr,string numexpl)
        {
            try
            {
                LigneEmprunt unligneEmprunt = new LigneEmprunt();
                MySqlConnection con = new Database().getconnection();
                string req = "select * from LigneEmprunt where numempr=?numempr,numexpl=?numexpl";
                MySqlParameter param = new MySqlParameter();
                param.Value = numempr;
                MySqlCommand cmd = new MySqlCommand(req, con);
                param.ParameterName = "Numero emprunt";
                cmd.Parameters.Add(param);
                param.Value = numexpl;
                param.ParameterName = "Numero exemplaire";
                cmd.Parameters.Add(param);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                if (lecteur.HasRows)
                {
                    if (lecteur.Read())
                    {
                        unligneEmprunt.Emprunt.Numempr = numempr;
                        unligneEmprunt.Exemplaire.Numexpl = lecteur.GetString("numexpl");
                        unligneEmprunt.Duree = lecteur.GetInt16("duree");
                        unligneEmprunt.Dateretour = lecteur.GetDateTime("dateretour");

                    }
                }
                else
                {
                    throw new Exception("ligne emprunt inexistant");
                }
                lecteur.Close();
                con.Close();
                return unligneEmprunt;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return null;
            }

        }
        public bool Suppr(string numempr,string numexpl)
        {
            try
            {


                //Insertion d'un etudiant dans la table etudiant
                //requetes parametrées
                MySqlConnection con = new Database().getconnection();
                string strRequeteSuppr = "delete from l where numempr=?numempr,numexpl=?numexpl";
                MySqlCommand cmd = new MySqlCommand(strRequeteSuppr, con);
                MySqlParameter param = new MySqlParameter();
                param.Value = numempr;
                param.ParameterName = "numempr";
                 param.Value = numexpl;
                 param.ParameterName = "numexpl";

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
