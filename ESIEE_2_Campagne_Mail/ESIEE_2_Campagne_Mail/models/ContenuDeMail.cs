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
        public string Expediteur { get; set; }
        public string Titre { get; set; }
        public string Rebound { get; set; }
        public string Contenu { get; set; }

        /**
         * Constructeur vide de la classe Message.
         */
        public ContenuDeMail()
        {
            Expediteur = "";
            Titre = "";
            Rebound = "";
            Contenu = "";
        }

        /**
         * Constructeur complet de la classe Message.
         */
        public ContenuDeMail(string expediteur, string titre, string rebound, string contenu)
        {
            Expediteur = expediteur;
            Titre = titre;
            Rebound = rebound;
            Contenu = contenu;
        }
        
        /// <summary>
        ///     Clear all fields
        /// </summary>
        public void Clear()
        {
            Expediteur = "";
            Titre = "";
            Rebound = "";
            Contenu = "";
        }
    }
}
