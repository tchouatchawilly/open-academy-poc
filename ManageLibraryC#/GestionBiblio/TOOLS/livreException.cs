using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.TOOLS
{
    class livreException:Exception
    {
          int natureErreur = 1;
        ENTITY.Livre livre;

          internal ENTITY.Livre Livre
           {
             get { return livre; }
             set { livre = value; }
           }

        public livreException(int nature, ENTITY.Livre livre1)
            : base("Erreur lors de l'ajout du livre" + livre1.Codeli)
        {
            natureErreur = nature;
            this.Livre = livre1;
        }
    }
}
