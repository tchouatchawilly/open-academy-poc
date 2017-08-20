using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.TOOLS
{
    class empruntException:Exception
    {
         int natureErreur = 1;
        ENTITY.Emprunt Emprunt;

        internal ENTITY.Emprunt Emprunt1
        {
            get { return Emprunt; }
            set { Emprunt = value; }
        }
        public empruntException(int nature, ENTITY.Emprunt Emprunt1)
            : base("Erreur lors de l'ajout de l'emprunt" + Emprunt1.Numempr)
        {
            natureErreur = nature;
            this.Emprunt1 = Emprunt1;
        }
        
    }
}
