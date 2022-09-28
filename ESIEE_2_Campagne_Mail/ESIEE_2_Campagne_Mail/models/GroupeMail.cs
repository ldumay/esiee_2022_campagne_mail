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

        /// <summary>
        /// Attribut de la liste des mails
        /// </summary>
        public List<string> MailsList { get; }
        /// <summary>
        /// Attribut de la liste des mails actifs
        /// </summary>
        public List<string> MailsActifsList { get; }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public GroupeMail()
        {
            MailsList = new List<string>();
            MailsActifsList = new List<string>();
        }

        /// <summary>
        /// Constructeur complet de la classe Campagne.
        /// </summary>
        /// <param name="mailsList"></param>
        /// <param name="mailsActifsList"></param>
        public GroupeMail(List<string> mailsList, List<string> mailsActifsList)
        {
            this.MailsList = mailsList;
            this.MailsActifsList = mailsActifsList;
        }

        /// <summary>
        /// Ajouter un mail à la liste des mails.
        /// </summary>
        /// <param name="mail"></param>
        public void ajouterMail(string mail)
        {
            MailsList.Add(mail);
        }
        
        /// <summary>
        /// Ajouter un mail à la liste des mails.
        /// </summary>
        /// <param name="mail"></param>
        public void retirerMail(string mail)
        {
            MailsList.Remove(mail);
        }

        /// <summary>
        /// Ajouter un mail à la liste des mails actifs.
        /// </summary>
        /// <param name="mail"></param>
        public void activerMail(string mail)
        {
            MailsActifsList.Add(mail);
        }

        /// <summary>
        /// Supprimer un mail à la liste des mails actifs.
        /// </summary>
        /// <param name="mail"></param>
        public void desactiverMail(string mail)
        {
            MailsActifsList.Remove(mail);
        }

    }
}
