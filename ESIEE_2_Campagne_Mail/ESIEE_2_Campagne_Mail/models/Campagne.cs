namespace ESIEE_2_Campagne_Mail.models
{
    /**
    * Classe Campagne.
    */
    public class Campagne
    {
        //Attribut du nom dela campagne
        private string nom;
        //Attribut de la liste des mails
        private List<GroupeMail> groupeMailList;
        //Attribut du message
        private ContenuDeMail contenuDeMail;

        //Getters & Setter
        public string Nom { get => nom; set => nom = value; }
        public List<GroupeMail> GroupeMailList { get => groupeMailList; set => groupeMailList = value; }
        public ContenuDeMail ContenuDeMail { get => contenuDeMail; set => contenuDeMail = value; }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public Campagne()
        {
            nom = "";
            groupeMailList = new List<GroupeMail>();
            contenuDeMail = new ContenuDeMail();
        }

        /**
         * Constructeur complet de la classe Campagne.
         */
        public Campagne(string nom,  List<GroupeMail> groupeMailList, ContenuDeMail message)
        {
            this.nom = nom;
            this.groupeMailList = groupeMailList;
            this.contenuDeMail = message;
        }

        /**
         * Changer le message contenu dans la campagne.
         */
        public void changerMessage(string message)
        {
            this.contenuDeMail.Contenu = message;
        }

        /**
         * Récupérer la liste des mails actifs des groupes mails.
         */
        public List<string> recupererListeMail()
        {
            try {
                List<string> listeMails = new List<string>();
                foreach (GroupeMail groupeMail in GroupeMailList)
                {
                    listeMails.AddRange(groupeMail.MailsList);
                }
                Console.WriteLine("[Recuperer Liste Mail]");
                return listeMails;
            }
            catch (Exception e)
            {
                Console.WriteLine("[Recuperer Liste Mail] Error\n" + e);
                return null;
            }
        }

        /**
         * Récupérer la liste des mails actifs des groupes mails.
         */
        public List<string> recupererListeMailActifs()
        {
            try {
                List<string> listeMails = new List<string>();
                foreach (GroupeMail groupeMail in GroupeMailList)
                {
                    listeMails.AddRange(groupeMail.MailsActifsList);
                }
                Console.WriteLine("[Recuperer Liste Mail Actifs] OK");
                return listeMails;
            }
            catch (Exception e)
            {
                Console.WriteLine("[Recuperer Liste Mail Actifs] Error\n" + e);
                return null;
            }
}

    }
}
