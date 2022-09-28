using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.models
{
    /// <summary>
    /// Classe GroupeContact.
    /// </summary>
    public class GroupeContact
    {
        public List<Contact> ContactList { get; set; }

        /// <summary>
        /// Constructeur vide de la classe Campagne.
        /// </summary>
        public GroupeContact()
        {
            ContactList = new List<Contact>();
        }

        /// <summary>
        /// Constructeur complet de la classe Campagne.
        /// </summary>
        /// <param name="mailsList"></param>
        /// <param name="mailsActifsList"></param>
        public GroupeContact(List<Contact> mailsList)
        {
            ContactList = mailsList;
        }

        /// <summary>
        /// Ajouter un contact à la liste des contacts.
        /// </summary>
        /// <param name="mail"></param>
        public void AjouterContact(Contact contact)
        {
            ContactList.Add(contact);
        }

        /// <summary>
        /// Retirer un contact à la liste des contacts.
        /// </summary>
        /// <param name="mail"></param>
        public void RetirerMail(Contact contact)
        {
            ContactList.Remove(contact);
        }

        /// <summary>
        /// Ajouter un contact à la liste des contacts actifs.
        /// - Soit, activer un mail.
        /// </summary>
        /// <param name="mail"></param>
        public void ActiverMail(Contact contact)
        {
            foreach (Contact contactInContactList in ContactList)
            {
                if (contactInContactList.Equals(contact))
                {
                    contactInContactList.Etat = ContactEtat.ACTIF;
                    break;
                }
            }
        }

        /// <summary>
        /// Supprimer un contact à la liste des contacts actifs.
        /// - Soit, désactiver un mail.
        /// </summary>
        /// <param name="mail"></param>
        public void DesactiverMail(Contact contact)
        {
            foreach (Contact contactInContactList in ContactList)
            {
                if (contactInContactList.Equals(contact))
                {
                    contactInContactList.Etat = ContactEtat.INACTIF;
                    break;
                }
            }
        }

    }
}
