namespace ESIEE_2_Campagne_Mail.models
{
    /**
     * Classe Contact
     */
    public class Contact
    {

        //Attributs du contact
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private ContactEtat etat;

        //Getters & Setter
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public ContactEtat Etat { get => etat; set => etat = value; }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public Contact()
        {
            id = 0;
            nom = "";
            prenom = "";
            email = "";
            etat = ContactEtat.INACTIF;
        }

        /**
         * Constructeur complet de la classe Campagne.
         */
        public Contact(int id, string nom, string prenom, string email, ContactEtat etat)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.etat = etat;
        }
    }
}
