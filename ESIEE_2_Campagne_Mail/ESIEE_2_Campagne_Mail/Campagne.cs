using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail
{
    internal class Campagne
    {

        //Attribut de la liste des mails
        private List<GroupeMail> groupeMailList;
        //Attribut du message
        private Message message;

        //Getters & Setter
        public Message Message{get; set;}
        public List<GroupeMail> GroupeMail { get; set;}

        /**
         * Constructeur vide de la classe Campagne.
         */
        public Campagne(){
            this.groupeMailList = new List<GroupeMail>();
            this.message = new Message();
        }

    }
}
