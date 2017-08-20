using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class LigneLivre
    {
        private Livre livre;

        internal Livre Livre
        {
            get { return livre; }
            set { livre = value; }
        }


        private Auteur auteur;

        internal Auteur Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

       
    }
}
