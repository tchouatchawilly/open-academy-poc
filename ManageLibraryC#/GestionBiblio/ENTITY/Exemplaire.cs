using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Exemplaire
    {
        private String numexpl = "";

        public String Numexpl
        {
            get { return numexpl; }
            set { numexpl = value; }
        }
        
        private Livre livre;

        internal Livre Livre
        {
            get { return livre; }
            set { livre = value; }
        }
    }
}
