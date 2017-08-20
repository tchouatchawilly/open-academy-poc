using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Lecteur
    {
        private String numlect = "";

        public String Numlect
        {
            get { return numlect; }
            set { numlect = value; }
        }
        private String nomlect = "";

        public String Nomlect
        {
            get { return nomlect; }
            set { nomlect = value; }
        }
        private String prenlect = "";

        public String Prenlect
        {
            get { return prenlect; }
            set { prenlect = value; }
        }
        private String telect = "";

        public String Telect
        {
            get { return telect; }
            set { telect = value; }
        }
        private String adrlect = "";

        public String Adrlect
        {
            get { return adrlect; }
            set { adrlect = value; }
        }
    }
}
