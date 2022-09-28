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

        /**
         * Constructeur vide de la classe Campagne.
         */
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

        /**
         * Changer le message contenu dans la campagne.
         */
        public void changerMessage(string message)
        {
            this.ContenuDeMail.Contenu = message;
        }

        /**
         * Récupérer la liste des mails actifs des groupes mails.
         */
        public List<string> recupererListeMail()
        {
            List<string> listeMails = new List<string>();
            try
            {
                foreach (GroupeContact groupeMail in GroupeMailList)
                {
                    if (groupeMail != null)
                    {
                        listeMails.AddRange(groupeMail.ContactList);
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

        /**
         * Récupérer la liste des mails actifs des groupes mails.
         */
        public List<string> recupererListeMailActifs()
        {
            List<string> listeMails = new List<string>();
            try
            {
                foreach (GroupeContact groupeMail in GroupeMailList)
                {
                    if (groupeMail != null)
                    {
                        listeMails.AddRange(groupeMail.MailsActifsList);
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
