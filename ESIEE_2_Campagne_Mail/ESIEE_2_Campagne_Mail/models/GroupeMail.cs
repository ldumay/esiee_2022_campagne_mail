using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.models
{
    /**
    * Classe GroupeMail.
    */
    public class GroupeMail
    {

        //Attribut de la liste des mails
        private List<string> mailsList;
        //Attribut de la liste des mails actifs
        private List<string> mailsActifsList;

        //Getters & Setter
        public List<string> MailsList { get => mailsList; set => mailsList = value; }
        public List<string> MailsActifsList { get => mailsActifsList; set => mailsActifsList = value; }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public GroupeMail()
        {
            mailsList = new List<string>();
            mailsActifsList = new List<string>();
        }

        /**
         * Constructeur complet de la classe Campagne.
         */
        public GroupeMail(List<string> mailsList, List<string> mailsActifsList)
        {
            this.mailsList = mailsList;
            this.mailsActifsList = mailsActifsList;
        }

        /**
         * Ajouter un mail à la liste des mails.
         */
        public void ajouterMail(string mail)
        {
            mailsList.Add(mail);
        }

        /**
         * Ajouter un mail à la liste des mails actifs.
         * Soit, activer un mail.
         */
        public void activerMail(string mail)
        {
            mailsActifsList.Add(mail);
        }

        /**
         * Supprimer un mail à la liste des mails actifs.
         * Soit, désactiver un mail.
         */
        public void desactiverMail(string mail)
        {
            mailsActifsList.Remove(mail);
        }

    }
}
