using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionBiblio.IHM
{
    public partial class Lecteur : Form
    {
        LecteurDAO empruntd = new LecteurDAO();
        Emprunt empruntCourant = null; //permet de connaitre le client courant
        List<Emprunt> listeEmprunt = new List<Emprunt>();//liste qui sera chargé au demarrage du formulaire
        int action = 0;
        public Lecteur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivationChamps(true);

            ViderChamps();

            action = 1;

            ActivationBouton(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ActivationChamps(false);
            ViderChamps();
            ActivationBouton(true);
            action = 0;  
        }

        private void button5_Click(object sender, EventArgs e)
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
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
                      
        }

        private void ActivationChamps(bool etat)
        {
            textBox1.Enabled = etat;
            textBox2.Enabled = etat;
            textBox3.Enabled = etat;
            textBox4.Enabled = etat;
            textBox5.Enabled = etat;
        }

        private void ActivationBouton(bool etat)
        {

            button1.Enabled = etat;
            button2.Enabled = etat;
            button3.Enabled = etat;
            button4.Enabled = !etat;
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ActivationChamps(false);
            ViderChamps();
            ActivationBouton(true);
            action = 0;  

        }

        }
    }

