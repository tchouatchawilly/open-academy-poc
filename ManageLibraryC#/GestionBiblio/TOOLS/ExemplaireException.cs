using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.TOOLS
{
    class ExemplaireException:Exception
    {
         int natureErreur = 1;
        ENTITY.Exemplaire Exemplaire;

        internal ENTITY.Exemplaire Exemplaire1
        {
          get { return Exemplaire; }
          set { Exemplaire = value; }
        }

          
        public ExemplaireException(int nature, ENTITY.Exemplaire Exemplaire1)
            : base("Erreur lors de l'ajout d'un exemplaire" + Exemplaire1.Numexpl)
        {
            natureErreur = nature;
            this.Exemplaire = Exemplaire1;
        }
    }
}
