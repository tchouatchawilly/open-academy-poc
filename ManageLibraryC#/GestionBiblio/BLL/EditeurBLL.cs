using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using GestionBiblio.DAO; 

namespace GestionBiblio.BLL
{
    class EditeurBLL
    {
        EditeurDAO dao = new EditeurDAO();
        GestionBiblio.ENTITY.Editeur editeur = null;

        internal GestionBiblio.ENTITY.Editeur EditeurEntity
        {
            get { return editeur; }
            set { editeur = value; }
        }
        public EditeurBLL()

        { 

        }
        public EditeurBLL(string codedit)
        {
            this.editeur = dao.getediteur(codedit);
        }
        public EditeurBLL(GestionBiblio.ENTITY.Editeur editeur)
        {
            this.editeur = editeur;
        }
        public bool ajouter()
        {
            return dao.ajouter(this.editeur);
        }
        public bool modifier()
        {
            return dao.Miseajour(this.editeur);
        }
    }
}
