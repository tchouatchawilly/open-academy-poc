using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using GestionBiblio.DAO; 

namespace GestionBiblio.BLL
{
    class LivreBLL
    {
        LivreDAO dao = new LivreDAO();
        GestionBiblio.ENTITY.Livre livre = null;

        internal GestionBiblio.ENTITY.Livre LivreEntity
        {
            get { return livre; }
            set { livre = value; }
        }
        public LivreBLL()

        { 

        }
        public LivreBLL(string codeli)
        {
            this.livre = dao.getlivre(codeli);
        }
        public LivreBLL(GestionBiblio.ENTITY.Livre livre)
        {
            this.livre = livre;
        }
        public bool ajouter()
        {
            return dao.ajouter(this.livre);
        }
        public bool modifier()
        {
            return dao.Miseajour(this.livre);
        }
    }
}
