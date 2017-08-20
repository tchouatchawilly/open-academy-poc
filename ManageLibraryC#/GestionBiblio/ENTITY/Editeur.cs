using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBiblio.ENTITY
{
    class Editeur
    {
        private String codedit = "";

        public String Codedit
        {
            get { return codedit; }
            set { codedit = value; }
        }
        private String nomedit = "";

        public String Nomedit
        {
            get { return nomedit; }
            set { nomedit = value; }
        }
        private String prenedit = "";


        public String Prenedit
        {
            get { return prenedit; }
            set { prenedit = value; }
        }
        private String teledit = "";

        public String Teledit
        {
            get { return teledit; }
            set { teledit = value; }
        }
        private String adredit = "";

        public String Adredit
        {
            get { return adredit; }
            set { adredit = value; }
        }
    }
}
