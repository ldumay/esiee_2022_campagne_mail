using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail.models
{
    /// <summary>
    /// Classe Campagne.
    /// </summary>
    public class Campagne
    {
        /// <summary>
        /// Attribut du nom dela campagne
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Attribut de la liste des mails
        /// </summary>
        public List<GroupeContact> ListGroupeContact { get; }
        /// <summary>
        /// Attribut du message
        /// </summary>
        public ContenuDeMail ContenuDeMail { get; set; }

        /// <summary>
        /// Constructeur vide de la classe Campagne.
        /// </summary>
        /// <param name="nom"></param>
        public Campagne(string nom)
        {
            Nom = nom;
            ListGroupeContact = new List<GroupeContact>();
            ContenuDeMail = new ContenuDeMail();
        }
        
        /// <summary>
        /// Constructeur complet de la classe Campagne.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="groupeMailList"></param>
        /// <param name="message"></param>
        public Campagne(string nom, List<GroupeContact> groupeMailList, ContenuDeMail message)
        {
            this.Nom = nom;
            this.ListGroupeContact = groupeMailList;
            this.ContenuDeMail = message;
        }

        /// <summary>
        /// Changer le message contenu dans la campagne.
        /// </summary>
        /// <param name="message"></param>
        public void changerMessage(string message)
        {
            this.ContenuDeMail.Contenu = message;
        }

        /// <summary>
        /// Récupérer la liste des contacts  actifs des groupes mails.
        /// </summary>
        /// <returns>listeContacts</returns>
        public List<Contact> recupererListeContacts()
        {
            List<Contact> listeContacts = new List<Contact>();
            try
            {
                foreach (GroupeContact groupeContact in ListGroupeContact)
                {
                    if (groupeContact != null)
                    {
                        foreach (Contact contact in groupeContact.ContactList)
                        {
                            listeContacts.Add(contact);
                        }
                    }
                }
                Debug.WriteLine("[Campagne] La récupération de la liste des contacts de la campagne a bien été effectué.");
            }
            catch (Exception e)
            {
                Debug.WriteLine("[Campagne] Erreur lors de la récupération de la liste des contacts de la campagne.\");\n" + e.Message);
            }
            return listeContacts;
        }

        /// <summary>
        /// Récupérer la liste des mails actifs des groupes mails.
        /// </summary>
        /// <returns>listeContacts</returns>
        public List<Contact> recupererListeContactsActifs()
        {
            List<Contact> listeMailsActifs = new List<Contact>();
            try
            {
                foreach (GroupeContact groupeContact in ListGroupeContact)
                {
                    if (groupeContact != null)
                    {
                        foreach (Contact contact in groupeContact.ContactList)
                        {
                            if (contact.Etat == ContactEtat.ACTIF)
                            {
                                listeMailsActifs.Add(contact);
                            }
                        }
                    }
                }
                Debug.WriteLine("[Campagne] La récupération de la liste des contacts actifs de la campagne a bien été effectué.");
            }
            catch (Exception e)
            {
                Debug.WriteLine("[Campagne] Erreur lors de la récupération de la liste des contacts actifs de la campagne.\n" + e.Message);
            }
            return listeMailsActifs;
        }
    }
}
