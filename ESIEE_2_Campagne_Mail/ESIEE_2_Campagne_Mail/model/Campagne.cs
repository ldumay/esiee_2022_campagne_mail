using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.Models
{
    /**
    * Classe Campagne.
    */
    internal class Campagne
    {
        //Attribut du nom dela campagne
        private string nom;
        //Attribut de la liste des mails
        private List<GroupeMail> groupeMailList;
        //Attribut du message
        private Message message;

        //Getters & Setter
        public string Nom { get; set; }
        public Message Message { get; set; }
        public List<GroupeMail> GroupeMail { get; set; }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public Campagne()
        {
            nom = "";
            groupeMailList = new List<GroupeMail>();
            message = new Message();
        }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public Campagne(string nom,  List<GroupeMail> groupeMailList, Message message)
        {
            this.nom = nom;
            this.groupeMailList = groupeMailList;
            this.message = message;
        }

        /**
         * Changer le message contenu dans la campagne.
         */
        public void changerMessage(string message)
        {
            this.message.Contenu = message;
        }

        /**
         * Récupérer la liste des mails actifs des groupes mails.
         */
        public List<string> recupererListeMailActif()
        {
            List<string> listeMails = new List<string>();
            foreach (GroupeMail groupeMail in groupeMailList)
            {
                listeMails.AddRange(groupeMail.MailsActifsList);
            }
            return listeMails;
        }

    }
}
