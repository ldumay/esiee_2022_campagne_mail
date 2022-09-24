using ESIEE_2_Campagne_Mail.Models;

namespace ESIEE_2_Campagne_Mail.model
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
        public string Nom { get; set; }
        public ContenuDeMail ContenuDeMail { get; set; }
        public List<GroupeMail> GroupeMail { get; set; }

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
         * Constructeur vide de la classe Campagne.
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
        public List<string> recupererListeMailActif()
        {
            List<string> listeMails = new List<string>();
            foreach (GroupeMail groupeMail in groupeMailList)
            {
                listeMails.AddRange(groupeMail.MailsActifsList);
            }
            return listeMails;
        }

    }
}
