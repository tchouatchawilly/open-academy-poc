using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GestionBiblio.ENTITY;
using GestionBiblio.DAO; 


namespace GestionBiblio.IHM
{
    public partial class Emprunt : Form
    {
        EmpruntDAO empruntd = new EmpruntDAO();
        Emprunt empruntCourant =null; //permet de connaitre le client courant
        List<Emprunt> listeEmprunt = new List<Emprunt>();//liste qui sera chargé au demarrage du formulaire
        int action = 0;

        public Emprunt()
        {
            InitializeComponent();
        }
        private void LoadGrille()
        {
            dataGridView1.Rows.Clear();
            List<Emprunt> listeEmprunt = Emprunt.getListeEmprunt();
            for (int i = 0; i < listeEmprunt.Count; i++)
            {
                dataGridView1.Rows.Add(new string[] {listeEmprunt[i].empruntd.Emprunt.Numempr}, new DateTime[]{ listeEmprunt[i].empruntd.Emprunt.Datempr}, new string[]{listeEmprunt[i].empruntd.Emprunt.Lecteur.Numlect });
            }
        }
 
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
         {
            Emprunt empruntCourant;
            empruntCourant = new Emprunt();
            Lecteur lect= new Lecteur();
            string numempr = dataGridView1[0, e.RowIndex].Value.ToString();
            empruntCourant.empruntd.Emprunt.Numempr = numempr;
            new DateTime(empruntCourant.empruntd.Emprunt.Datempr= dataGridView1["datempr", e.RowIndex].Value.ToString(); 
            empruntCourant.lect.Numlect = dataGridView1["numlect", e.RowIndex].Value.ToString();
            txtnuempr.Text = empruntCourant.Numempr;
            dtpdate.Text = empruntCourant.Datempr;
            textBox1.Text = empruntCourant.lect.Numlect;
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ActivationChamps(true);

            ViderChamps();

            action = 1;

            ActivationBouton(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Emprunt_Load(object sender, EventArgs e)
        {
            btnAnnuler_Click(new object(), new EventArgs());
            LoadGrille();  
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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
        
            ActivationChamps(false);
            ViderChamps();
            ActivationBouton(true);
            action = 0;  

        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
          BLL.EmpruntBLL empb = new BLL.EmpruntBLL();
          ENTITY.Emprunt emp = new ENTITY.Emprunt();
          ENTITY.Lecteur lect = new ENTITY.Lecteur();
           emp.Numempr = textBox1.Text;
           emp.Datempr = dtpdate.Value;
        
            if (action == 1)
            {
                empb.ajouter();
            }
            if (action == 2)
            {
                empb.modifier();
            }
            ActivationChamps(false);
            ViderChamps();
            ActivationBouton(true);
            action = 0;
            MessageBox.Show("Enregistrement réussi");
            LoadGrille();
            

        }
                  private void ViderChamps()
        {
            textBox1.Text = "";
            dtpdate.Text = "";
            cmb.Text = "";
        }

        private void ActivationChamps(bool etat)
        {
            textBox1.Enabled = etat;
            dtpdate.Enabled = etat;
            cmb.Enabled = etat; 
        }

        private void ActivationBouton(bool etat)
        {

            btnAjouter.Enabled = etat;
            btnModifier.Enabled = etat;
            btnSupprimer.Enabled = etat;
            btnAnnuler.Enabled = !etat;
          
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }


        }
    }

