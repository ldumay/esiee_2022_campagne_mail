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

        /// <summary>
        /// Constructeur vide de la classe Campagne.
        /// </summary>
        /// <param name="nom"></param>
        public Campagne(string nom)
        {
            Nom = nom;
            GroupeMailList = new List<GroupeMail>();
            ContenuDeMail = new ContenuDeMail();
        }

        /// <summary>
        /// Constructeur complet de la classe Campagne.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="groupeMailList"></param>
        /// <param name="message"></param>
        public Campagne(string nom, List<GroupeMail> groupeMailList, ContenuDeMail message)
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

        /// <summary>
        /// Récupérer la liste des mails actifs des groupes mails.
        /// </summary>
        /// <returns>Liste de mail actif</returns>
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
