using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionBiblio.ENTITY;
using GestionBiblio.DAO; 

namespace GestionBiblio.BLL
{
    class ExemplaireBLL
    {

        ExemplaireDAO dao = new ExemplaireDAO();
        GestionBiblio.ENTITY.Exemplaire exemplaire = null;

        internal GestionBiblio.ENTITY.Exemplaire ExemplaireEntity
        {
            get { return exemplaire; }
            set { exemplaire = value; }
        }
        public ExemplaireBLL()

        { 

        }
        public ExemplaireBLL(string numexpl)
        {
            this.exemplaire = dao.getexemplaire(numexpl);
        }
        public ExemplaireBLL(GestionBiblio.ENTITY.Exemplaire exemplaire)
        {
            this.exemplaire = exemplaire;
        }
        public bool ajouter()
        {
            return dao.ajouter(this.exemplaire);
        }
        public bool modifier()
        {
            return dao.Miseajour(this.exemplaire);
        }
    }
}
