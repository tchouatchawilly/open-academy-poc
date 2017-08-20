using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class LigneEmprunt
    {
        private Emprunt emprunt;

        internal Emprunt Emprunt
        {
            get { return emprunt; }
            set { emprunt = value; }
        }


        private Exemplaire exemplaire;


        internal Exemplaire Exemplaire
        {
            get { return exemplaire; }
            set { exemplaire = value; }
        }

        private int duree;

        public int Duree
        {
            get { return duree; }
            set { duree = value; }

        }

        private DateTime dateretour;

        public DateTime Dateretour
        {
            get { return dateretour; }
            set { dateretour = value; }
        }

        
    }
}
