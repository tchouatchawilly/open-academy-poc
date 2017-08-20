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
    public partial class LigneEmprunt : Form
    {
        public LigneEmprunt()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           /* LigneEmprunt ligneCourant;
            ligneCourant = new LigneEmprunt();
            string numempr,numexpl = dataGridView1[0, e.RowIndex].Value.ToString();
            ligneCourant.Numempr = numempr;
            ligneCourant.Numexpl = numexpl;
            ligneCourant.Numempr = dataGridView1["numempr", e.RowIndex].Value.ToString();
            ligneCourant.Numexpl = dataGridView1["numexpl", e.RowIndex].Value.ToString();
            ligneCourant.Duree = dataGridView1["duree", e.RowIndex].Value.ToString();
            ligneCourant.Numlect = dataGridView1["numlect", e.RowIndex].Value.ToString();
            txtnuempr.Text = ligneCourant.Numempr;
            dtpdate.Text = ligneCourant.Datempr;
            textBox1.Text = ligneCourant.lect.Numlect;
            textBox1.Text = ligneCourant.lect.Numlect;*/
        }

        private void btnmod_Click(object sender, EventArgs e)
        {

        }
    }
}
