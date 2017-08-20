using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using MySql.Data.MySqlClient;

namespace GestionBiblio.DAO
{
    class LivreDAO
    {
         public bool ajouter(Livre livre)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteAjout = "insert into livre VALUES (?codeli, ?nomli, ?dataparition,?codthem, ?codedit)";
                MySqlCommand cmd = new MySqlCommand(strRequeteAjout, con);
                defparametre(livre, cmd);

                //exécution de la commande
                cmd.CommandText = strRequeteAjout;
                cmd.ExecuteNonQuery();
                con.Close(); //fermeture de la connection
                con.Dispose();//liberer les ressources
                return true;
            }
            catch (Exception ex)
            {
                throw new TOOLS.livreException(1, livre);
            }
        }

        private static MySqlParameter defparametre(Livre livre, MySqlCommand cmd)
        {
             Theme T = new Theme();
             Editeur E = new Editeur();
            MySqlParameter param = new MySqlParameter();
            param.Value = livre.Codeli;
            param.ParameterName = "code livre";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = livre.Nomli;
            param.ParameterName = "nom livre";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = livre.Dataparition;
            param.ParameterName = "date apparition";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = T.Codthem;
            param.ParameterName = "code theme";
            cmd.Parameters.Add(param);
            param = new MySqlParameter();
            param.Value = E.Codedit;
            param.ParameterName = "code editeur";
            cmd.Parameters.Add(param);

            return param;
        }
        public bool Miseajour(Livre livre)
        {
            try
            {
                MySqlConnection con = new Database().getconnection();
                string strRequeteMiseajour = "update livre set nomli=?nomli ,dataparition =?dataparition, codthem=?codthem,codedit=?codedit where codeli=?codeli";
                MySqlCommand cmd = new MySqlCommand(strRequeteMiseajour, con);

                defparametre(livre, cmd);

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
        public Livre getlivre(string codeli)
        {
            try
            {
                Livre unLivre = new Livre();
                MySqlConnection con = new Database().getconnection();
                string req = "select * from livre where codeli=?codeli";
                MySqlParameter param = new MySqlParameter();
                param.Value = codeli;
                MySqlCommand cmd = new MySqlCommand(req, con);
                param.ParameterName = "code livre";
                cmd.Parameters.Add(param);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                if (lecteur.HasRows)
                {
                    if (lecteur.Read())
                    {
                        unLivre.Codeli = codeli;
                        unLivre.Nomli = lecteur.GetString("nomli");
                        unLivre.Editeur.Codedit=lecteur.GetString("codedit");
                        unLivre.Theme.Codthem= lecteur.GetString("codthem");

                    }
                }
                else
                {
                    throw new Exception("code livre inexistant");
                }
                lecteur.Close();
                con.Close();
                return unLivre;
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return null;
            }

        }
        public bool Suppr(string codeli)
        {
            try
            {


                //Insertion d'un etudiant dans la table etudiant
                //requetes parametrées
                MySqlConnection con = new Database().getconnection();
                string strRequeteSuppr = "delete from livre where codeli=?codeli";
                MySqlCommand cmd = new MySqlCommand(strRequeteSuppr, con);
                MySqlParameter param = new MySqlParameter();
                param.Value = codeli;
                param.ParameterName = "codeli";

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
