using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using GestionBiblio.DAO; 

namespace GestionBiblio.BLL
{
    class EmpruntBLL
    {
        EmpruntDAO dao = new EmpruntDAO();
        GestionBiblio.ENTITY.Emprunt emprunt = null;

         internal GestionBiblio.ENTITY.Emprunt EmpruntEntity
           {
             get { return emprunt; }
             set { emprunt = value; }
           }
 
        public EmpruntBLL()

        { 

        }
        public EmpruntBLL(string numempr)
        {
            this.emprunt = dao.getemprunt(numempr);
        }
        public EmpruntBLL(GestionBiblio.ENTITY.Emprunt emprunt)
        {
            this.emprunt = emprunt;
        }
        public bool ajouter()
        {
            return dao.ajouter(this.emprunt);
        }
        public bool modifier()
        {
            return dao.Miseajour(this.emprunt);
        }
    }
}
