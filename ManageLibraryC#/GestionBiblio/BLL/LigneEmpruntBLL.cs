using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using GestionBiblio.DAO; 

namespace GestionBiblio.BLL
{
    class LigneEmpruntBLL
    {
        LigneEmpruntDAO dao = new LigneEmpruntDAO();
        GestionBiblio.ENTITY.LigneEmprunt ligne = null;

        internal GestionBiblio.ENTITY.LigneEmprunt LigneEntity
        {
            get { return ligne; }
            set { ligne = value; }
        }
        public LigneEmpruntBLL()

        { 

        }
        public LigneEmpruntBLL(string numempr,string numexpl)
        {   Emprunt emp = new Emprunt();
            Exemplaire Exp = new Exemplaire();
            this.ligne = dao.getligne(numempr,numexpl);
        }
        public LigneEmpruntBLL(GestionBiblio.ENTITY.LigneEmprunt ligne)
        {
            this.ligne = ligne;
        }
        public bool ajouter()
        {
            return dao.ajouter(this.ligne);
        }
        public bool modifier()
        {
            return dao.Miseajour(this.ligne);
        }
    }
}
