using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Auteur
    {
        private String nomaut = "";

        public String Nomaut
        {
            get { return nomaut; }
            set { nomaut = value; }
        }
        private String prenaut = "";

        public String Prenaut
        {
            get { return prenaut; }
            set { prenaut = value; }
        }
        private String telaut = "";

        public String Telaut
        {
            get { return telaut; }
            set { telaut = value; }
        }
        private String adraut = "";

        public String Adraut
        {
            get { return adraut; }
            set { adraut = value; }
        }
    }
}
