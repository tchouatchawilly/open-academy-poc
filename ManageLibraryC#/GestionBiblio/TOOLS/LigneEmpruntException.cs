using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.TOOLS
{
    class LigneEmpruntException:Exception
    {
        
         int natureErreur = 1;
        ENTITY.LigneEmprunt ligne;

            internal ENTITY.LigneEmprunt Ligne
            {
              get { return ligne; }
              set { ligne = value; }
            }

        public LigneEmpruntException(int nature, ENTITY.LigneEmprunt ligne1)
            : base("Erreur lors de l'ajout d'une ligne d'emprunt" + ligne1.Emprunt.Numempr+ ligne1.Exemplaire.Numexpl)
        {
            natureErreur = nature;
            this.ligne = ligne1;
        }
    }
    
}
