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
        public List<GroupeContact> GroupeMailList { get; }
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
            GroupeMailList = new List<GroupeContact>();
            ContenuDeMail = new ContenuDeMail();
        }

        /**
         * Constructeur complet de la classe Campagne.
         */
        public Campagne(string nom, List<GroupeContact> groupeMailList, ContenuDeMail message)
        {
            this.Nom = nom;
            this.GroupeMailList = groupeMailList;
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
        /// Récupérer la liste des mails actifs des groupes mails.
        /// </summary>
        /// <returns>Liste de mail</returns>
        public List<string> recupererListeMail()
        {
            List<string> listeMails = new List<string>();
            try
            {
                foreach (GroupeContact groupeContact in GroupeMailList)
                {
                    if (groupeContact != null)
                    {
                        foreach (Contact contact in groupeContact.ContactList)
                        {
                            listeMails.Add(contact.Email);
                        }
                    }
                }
                Console.WriteLine("[Recuperer Liste Mail]");
            }
            catch (Exception e)
            {
                Console.WriteLine("[Recuperer Liste Mail] Error\n" + e.Message);
            }
            return listeMails;
        }

        /// <summary>
        /// Récupérer la liste des mails actifs des groupes mails.
        /// </summary>
        /// <returns>Liste de mail actif</returns>
        public List<string> recupererListeMailActifs()
        {
            List<string> listeMails = new List<string>();
            try
            {
                foreach (GroupeContact groupeContact in GroupeMailList)
                {
                    if (groupeContact != null)
                    {
                        foreach (Contact contact in groupeContact.ContactList)
                        {
                            if (contact.Etat == ContactEtat.ACTIF)
                            {
                                listeMails.Add(contact.Email);
                            }
                        }
                    }
                }
                Console.WriteLine("[Recuperer Liste Mail Actifs] OK");
            }
            catch (Exception e)
            {
                Console.WriteLine("[Recuperer Liste Mail Actifs] Error\n" + e.Message);
            }
            return listeMails;
        }
    }
}
