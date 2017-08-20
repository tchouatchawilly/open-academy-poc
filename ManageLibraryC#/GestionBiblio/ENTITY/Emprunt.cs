using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Emprunt
    {
        private String numempr = "";

        public String Numempr
        {
            get { return numempr; }
            set { numempr = value; }
        }
        private DateTime datempr;

        public DateTime Datempr
        {
            get { return datempr; }
            set { datempr = value; }
        }
        private Lecteur lecteur;

        internal Lecteur Lecteur
        {
            get { return lecteur; }
            set { lecteur = value; }
        }
    }
}
