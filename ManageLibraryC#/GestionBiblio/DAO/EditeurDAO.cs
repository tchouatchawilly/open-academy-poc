using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using MySql.Data.MySqlClient;

namespace GestionBiblio.DAO
{
    class EditeurDAO
    {
        public bool ajouter(Editeur editeur)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteAjout = "insert into editeur VALUES (?codedit, ?nomedit,?prenedit, ?teledit,?adredit)";
                MySqlCommand cmd = new MySqlCommand(strRequeteAjout, con);
                defparametre(editeur, cmd);

                //exécution de la commande
                cmd.CommandText = strRequeteAjout;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception )
            {
                throw new TOOLS.EditeurException(1, editeur);
            }
        }

        private static MySqlParameter defparametre(Editeur editeur, MySqlCommand cmd)
        {
            MySqlParameter param = new MySqlParameter();
            param.Value = editeur.Codedit;
            param.ParameterName = "code editeur";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = editeur.Nomedit;
            param.ParameterName = "nom editeur";
            cmd.Parameters.Add(param);
            param.Value = editeur.Prenedit;
            param.ParameterName = "prenom editeur";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = editeur.Teledit;
            param.ParameterName = "telephone editeur";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = editeur.Adredit;
            param.ParameterName = "adresse editeur";
            cmd.Parameters.Add(param);
            return param;
        }
        public bool Miseajour(Editeur editeur)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteMiseajour = "update editeur set ?nomedit, ?prenedit,?teledit, ?adredit where codedit=?codedit";
                MySqlCommand cmd = new MySqlCommand(strRequeteMiseajour, con);

                defparametre(editeur, cmd);

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
        public Editeur getediteur(string codedit)
        {
            try
            {
                Editeur unEditeur = new Editeur();
                MySqlConnection con = new Database().getconnection();
                string req = "select * from editeur where codedit=?codedit";
                MySqlParameter param = new MySqlParameter();
                param.Value = codedit;
                MySqlCommand cmd = new MySqlCommand(req, con);
                param.ParameterName = "code editeur";
                cmd.Parameters.Add(param);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                if (lecteur.HasRows)
                {
                    if (lecteur.Read())
                    {
                        unEditeur.Codedit = codedit;
                        unEditeur.Nomedit = lecteur.GetString("nomedit");
                        unEditeur.Prenedit = lecteur.GetString("prenedit");
                        unEditeur.Teledit = lecteur.GetString("teledit");
                        unEditeur.Adredit = lecteur.GetString("adredit");
                    }
                }
                else
                {
                    throw new Exception("editeur inexistant");
                }
                lecteur.Close();
                con.Close();
                return unEditeur;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return null;
            }

        }
        public bool Suppr(string codedit)
        {
            try
            {


                //Insertion d'un etudiant dans la table etudiant
                //requetes parametrées
                MySqlConnection con = new Database().getconnection();
                string strRequeteSuppr = "delete from editeur where codedit=?codedit";
                MySqlCommand cmd = new MySqlCommand(strRequeteSuppr, con);
                MySqlParameter param = new MySqlParameter();
                param.Value = codedit;
                param.ParameterName = "codedit";

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
