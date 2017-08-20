using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.TOOLS
{
    class EditeurException:Exception
    {
        
         int natureErreur = 1;
        ENTITY.Editeur Editeur;

            internal ENTITY.Editeur Editeur1
            {
              get { return Editeur; }
              set { Editeur = value; }
            }
        public EditeurException(int nature, ENTITY.Editeur Editeur1)
            : base("Erreur lors de l'ajout d'un editeur" + Editeur1.Codedit)
        {
            natureErreur = nature;
            this.Editeur = Editeur1;
        }
    }
}
