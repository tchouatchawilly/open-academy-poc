using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using MySql.Data.MySqlClient;

namespace GestionBiblio.DAO
{
    class ExemplaireDAO
    {
        public bool ajouter(Exemplaire exemplaire)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteAjout = "insert into exemplaire VALUES (?numexpl, ?codeli)";
                MySqlCommand cmd = new MySqlCommand(strRequeteAjout, con);
                defparametre(exemplaire, cmd);

                //exécution de la commande
                cmd.CommandText = strRequeteAjout;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception ex)
            {
                throw new TOOLS.ExemplaireException(1, exemplaire);
            }
        }

        private static MySqlParameter defparametre(Exemplaire exemplaire, MySqlCommand cmd)
        {
            Livre L = new Livre();
            MySqlParameter param = new MySqlParameter();
            param.Value = exemplaire.Numexpl;
            param.ParameterName = "numero exemplaire";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = L.Codeli;
            param.ParameterName = "code du livre";
            cmd.Parameters.Add(param);
            return param;
        }
        public bool Miseajour(Exemplaire exemplaire)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteMiseajour = "update exemplaire set codeli=?codeli where numexpl=?numexpl";
                MySqlCommand cmd = new MySqlCommand(strRequeteMiseajour, con);

                defparametre(exemplaire, cmd);

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
        public Exemplaire getexemplaire(string numexpl)
        {
            try
            {
                Exemplaire unExemplaire = new Exemplaire();
                MySqlConnection con = new Database().getconnection();
                string req = "select * from exemplaire where numexpl=?numexpl";
                MySqlParameter param = new MySqlParameter();
                param.Value = numexpl;
                MySqlCommand cmd = new MySqlCommand(req, con);
                param.ParameterName = "numero exemplaire";
                cmd.Parameters.Add(param);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                if (lecteur.HasRows)
                {
                    if (lecteur.Read())
                    {
                        unExemplaire.Numexpl = numexpl;
                        unExemplaire.Livre.Codeli = lecteur.GetString("codeli");
                    }
                }
                else
                {
                    throw new Exception("exemplaire inexistant");
                }
                lecteur.Close();
                con.Close();
                return unExemplaire;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return null;
            }

        }
        public bool Suppr(string numexpl)
        {
            try
            {


                //Insertion d'un etudiant dans la table etudiant
                //requetes parametrées
                MySqlConnection con = new Database().getconnection();
                string strRequeteSuppr = "delete from exemplaire where numexpl=?numexpl";
                MySqlCommand cmd = new MySqlCommand(strRequeteSuppr, con);
                MySqlParameter param = new MySqlParameter();
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
