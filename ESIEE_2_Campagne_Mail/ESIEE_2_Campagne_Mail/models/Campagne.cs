namespace ESIEE_2_Campagne_Mail.models
{
    /**
    * Classe Campagne.
    */
    public class Campagne
    {
        /// <summary>
        /// Attribut du nom dela campagne
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Attribut de la liste des mails
        /// </summary>
        public List<GroupeMail> GroupeMailList { get; }
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
            GroupeMailList = new List<GroupeMail>();
            ContenuDeMail = new ContenuDeMail();
        }

        /**
         * Constructeur complet de la classe Campagne.
         */
        public Campagne(string nom, List<GroupeMail> groupeMailList, ContenuDeMail message)
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
                foreach (GroupeMail groupeMail in GroupeMailList)
                {
                    if (groupeMail != null)
                    {
                        listeMails.AddRange(groupeMail.MailsList);
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
                foreach (GroupeMail groupeMail in GroupeMailList)
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
