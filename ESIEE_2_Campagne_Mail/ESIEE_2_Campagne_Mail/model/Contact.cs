using ESIEE_2_Campagne_Mail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.model
{
    /**
     * Classe Contact
     */
    public class Contact
    {

        //Attribut id
        private int id;
        //Attribut nom
        private string nom;
        //Attribut prenom
        private string prenom;
        //Attribut email
        private string email;

        //Getters & Setter
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }

        /**
         * Constructeur vide de la classe Campagne.
         */
        public Contact()
        {
            id = 0;
            nom = "";
            prenom = "";
            email = "";
        }

        /**
         * Constructeur complet de la classe Campagne.
         */
        public Contact(int id, string nom, string prenom, string email)
        {
            id = 0;
            nom = nom;
            prenom = prenom;
            email = email;
        }
    }
}
