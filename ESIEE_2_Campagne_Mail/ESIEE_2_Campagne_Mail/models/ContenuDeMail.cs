using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.models
{
    /**
    * Classe Message.
    */
    public class ContenuDeMail
    {

        //Attribut de la liste des mails
        private string expediteur;
        private string titre;
        private string rebound;
        private string contenu;

        //Getters & Setter
        public string Expediteur { get => expediteur; set => expediteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Rebound { get => rebound; set => rebound = value; }
        public string Contenu { get => contenu; set => contenu = value; }

        /**
         * Constructeur vide de la classe Message.
         */
        public ContenuDeMail()
        {
            expediteur = "";
            titre = "";
            rebound = "";
            contenu = "";
        }

        /**
         * Constructeur complet de la classe Message.
         */
        public ContenuDeMail(string expediteur, string titre, string rebound, string contenu)
        {
            this.expediteur = expediteur;
            this.titre = titre;
            this.rebound = rebound;
            this.contenu = contenu;
        }
    }
}
