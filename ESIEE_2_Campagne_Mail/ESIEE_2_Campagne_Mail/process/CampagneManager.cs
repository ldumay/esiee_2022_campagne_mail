using ESIEE_2_Campagne_Mail.models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
    /// <summary>
    /// Classse CampagneManager.
    /// </summary>
    internal class CampagneManager
    {
        private Campagne Campagne { get; }
        /// <summary>
        /// Attribut de la Campagne.
        /// </summary>
        private SMTPConnectionHandler SMTPConnectionHandler { get; }
        /// <summary>
        /// Attribut du SMTPConnectionHandler.
        /// </summary>
        public Boolean statutCampagneListeEmails { get; set; }
        /// <summary>
        /// Attribut du statut de la liste des mails de la campagne.
        /// </summary>
        public Boolean statutCampagneMessage { get; set; }
        /// <summary>
        /// Attribut du statut du message de la campagne.
        /// </summary>
        public Boolean statutCampagne { get; set; }
        /// <summary>
        /// Attribut du statut de la campagne.
        /// </summary>
        public Boolean statutSendReady { get; set; }
        /// <summary>
        /// Attribut du statut de l'envoi de la campagne.
        /// </summary>
        public Boolean statutSMTPServer { get; set; }
        /// <summary>
        /// Attribut du statut de l'envoi de la campagne.
        /// </summary>

        public CampagneManager(string nomCampagne)
        {
            Campagne = new Campagne(nomCampagne);
            SMTPConnectionHandler = new SMTPConnectionHandler();
        }

        /// <summary>
        /// Ajoute le groupe de contact dans la campagne.
        /// </summary>
        /// <param name="contacts"></param>
        internal void AddGroupContact(GroupeContact contacts)
        {
            Campagne.ListGroupeContact.Add(contacts);
        }

        [Obsolete("Sert juste d'entre-deux commits")]
        internal Campagne GetCampagne()
        {
            return Campagne;
        }
        
        [Obsolete("Sert juste d'entre-deux commits")]
        internal SMTPConnectionHandler GetSMTPConnectionHandler()
        {
            return SMTPConnectionHandler;
        }

        [Obsolete("Sert juste d'entre-deux commits")]
        internal List<GroupeContact> GetGroupContactList()
        {
            return Campagne.ListGroupeContact;
        }

        /// <summary>
        /// Retourne le contenu du mail de la campagne.
        /// </summary>
        /// <returns></returns>
        internal ContenuDeMail GetContenuDuMail()
        {
            ContenuDeMail contenuDeMail = Campagne.ContenuDeMail ?? new ContenuDeMail();
            return contenuDeMail;
        }

        /// <summary>
        /// Change le contenu du message envoyé.
        /// </summary>
        /// <param name="expediteur"></param>
        /// <param name="titre"></param>
        /// <param name="rebound"></param>
        /// <param name="contenu"></param>
        internal void ChangerContenuDuMail(string? expediteur, string? titre, string? rebound, string? contenu)
        {
            ContenuDeMail contenuDeMail = GetContenuDuMail();
            expediteur = string.IsNullOrEmpty(expediteur) ? contenuDeMail.Expediteur : expediteur;
            titre = string.IsNullOrEmpty(titre) ? contenuDeMail.Titre : titre;
            contenu = string.IsNullOrEmpty(contenu) ? contenuDeMail.Contenu : contenu;
            rebound = string.IsNullOrEmpty(rebound) ? contenuDeMail.Rebound : rebound;
            Campagne.ContenuDeMail = new ContenuDeMail(expediteur, titre, rebound, contenu);
        }

        /// <summary>
        /// Vérification des majuscules dans la liste des emails de la campagne.
        /// </summary>
        internal void CleanMajusculeListeContacts()
        {
            Debug.WriteLine("[Campagne] - Début du nettoyage des majuscules de la liste des contacts");
            //-
            List<GroupeContact> groupeContactList = Campagne.ListGroupeContact;
            foreach (GroupeContact groupeContact in groupeContactList)
            {
                List<Contact> contactList = groupeContact.ContactList;
                foreach (Contact contact in contactList)
                {
                    contact.Email = contact.Email.ToLower();
                }
            }
            //-
            string message = "Le nettoyage des majuscules des emails de la liste des contacts a bien été effectué.";
            MessageBox.Show(message, "Liste des emails - Nettoyage des majuscules terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Debug.WriteLine("[Campagne] - Fin du nettoyage des majuscules des emails de la liste des contacts");
        }
        
        /// <summary>
        /// Vérification des doublons existants dans la liste des emails de la campagne.
        /// </summary>
        internal void DedoublonnageListeContacts()
        {
            Debug.WriteLine("[Campagne] - Début du dédoublonnage de la liste des contacts");
            //-
            int compteur = 0;
            List<string> emailsNonDoublons = new List<string>();
            //-
            List<GroupeContact> groupeContactList = Campagne.ListGroupeContact;
            foreach (GroupeContact groupeContact in groupeContactList)
            {
                List<Contact> contactList = groupeContact.ContactList;
                foreach (Contact contact in contactList)
                {
                    if (!emailsNonDoublons.Contains(contact.Email.ToLower()))
                    {
                        emailsNonDoublons.Add(contact.Email.ToLower());
                    }
                    else
                    {
                        compteur++;
                        contact.Etat = ContactEtat.DOUBLON;
                        Debug.WriteLine("Doublon trouvé : " + contact.Email);
                    }
                }
            }
            //-
            string messagePart1 = "Le dédoublonnage a bien été effectué.";
            string messagePart2 = "Doublon total trouvé : " + compteur;
            string message = messagePart1 + "\n" + messagePart2;
            MessageBox.Show(message, "Liste des emails - Dédoublonnage terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Debug.WriteLine("[Campagne] - " + messagePart2);
            Debug.WriteLine("[Campagne] - Fin du dédoublonnage de la liste des contacts");
        }

        /// <summary>
        /// Nettoyage de la liste des contacts de la campagne.
        /// </summary>
        public void ClearListeContacts() {
            Campagne.ListGroupeContact.Clear();
            this.statutCampagneListeEmails = false;
        }
    }
}
