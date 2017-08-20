using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Livre
    {
        private String codeli;

        public String Codeli
        {
            get { return codeli; }
            set { codeli = value; }
        }
        private String nomli;

        public String Nomli
        {
            get { return nomli; }
            set { nomli = value; }
        }
        private DateTime dataparition;

        public DateTime Dataparition
        {
            get { return dataparition; }
            set { dataparition = value; }
        }

        private Theme theme;

        internal Theme Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        private Editeur editeur;

        internal Editeur Editeur
        {
            get { return editeur; }
            set { editeur = value; }
        }
    }
}
