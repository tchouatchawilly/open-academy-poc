using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Theme
    {
        private String codthem = "";

        public String Codthem
        {
            get { return codthem; }
            set { codthem = value; }
        }
        private String libthem = "";

        public String Libthem
        {
            get { return libthem; }
            set { libthem = value; }
        }
    }
}
