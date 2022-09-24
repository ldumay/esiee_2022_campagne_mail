using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.Models
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
        public string Expediteur { get; set; }
        public string Titre { get; set; }
        public string Rebound { get; set; }
        public string Contenu { get; set; }

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
