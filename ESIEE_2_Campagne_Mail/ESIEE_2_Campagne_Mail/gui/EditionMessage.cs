using ESIEE_2_Campagne_Mail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESIEE_2_Campagne_Mail
{
    public partial class EditionMessage : Form
    {
        public EditionMessage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        /**
         * Récuprération de l'expéditeur via le champs expéditeur.
         */
        private void textBoxEXP_TextChanged(object sender, EventArgs e)
        {
            //Home.Instance.campagne.Message.Expediteur = textBoxEXP.Text.ToString();
        }

        /**
         * Récuprération du message via le champs message.
         */
        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            //Home.Instance.campagne.Message.Contenu = textBoxMessage.Text.ToString();
        }

        /**
         * Récuprération du titre via le champs titre.
         */
        private void textBoxTitre_TextChanged(object sender, EventArgs e)
        {
           //Home.Instance.campagne.Message.Titre = textBoxTitre.Text.ToString();
        }

        /**
         * Récuprération du rebound via le champs rebound.
         */
        private void textBoxRebound_TextChanged(object sender, EventArgs e)
        {
            //Home.Instance.campagne.Message.Rebound = textBoxRebound.Text.ToString();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if(
                updateContenuDeMail(
                    (textBoxEXP.Text != null) ? (string) textBoxEXP.Text : null,
                    (textBoxTitre.Text != null) ? (string)textBoxTitre.Text : null,
                    (textBoxMessage.Text != null) ? (string)textBoxMessage.Text : null,
                    (textBoxRebound.Text != null) ? (string)textBoxRebound.Text : null
                )
            ) {
                Console.WriteLine("Contenu de mail : " + Home.Instance.campagne.ContenuDeMail);
                //-
                this.Close();
            }
            else
            {
                Console.WriteLine("Erreur lors de la sauvegarde du contenu de mail");
            }

        }

        /**
         * Vérification et édition de l'instance de ContenuDeMail dans l'instance de la Campagne.
         */
        private bool updateContenuDeMail(string expediteur, string titre, string contenu, string rebound){
            //Préparation instance de ContenuDeMail vide pour édition de l'instance de ContenuDeMail dans l'instance de la Campagne.
            ContenuDeMail contenuDeMail = null;

            //Vérification de l'adresse mail de l'expéditeur et du rebound.
            bool isExpediteurMail = verifEmail(expediteur);
            bool isReboundMail = verifEmail(rebound);
            if (isExpediteurMail && isReboundMail)
            {
                //Vérification de l'instance de ContenuDeMail dans l'instance de la Campagne.
                try
                {
                    //==> Récupération ou Création
                    if (Home.Instance.campagne.ContenuDeMail != null)
                    {
                        //Récupération
                        contenuDeMail = Home.Instance.campagne.ContenuDeMail;
                        //Edition
                        contenuDeMail.Expediteur = (expediteur != null) ? expediteur : "";
                        contenuDeMail.Titre = (titre != null) ? titre : "";
                        contenuDeMail.Contenu = (contenu != null) ? contenu : "";
                        contenuDeMail.Rebound = (rebound != null) ? rebound : "";
                    }
                    else
                    {
                        //Création
                        contenuDeMail = new ContenuDeMail();
                        //Edition
                        contenuDeMail.Expediteur = (expediteur != null) ? expediteur : "";
                        contenuDeMail.Titre = (titre != null) ? titre : "";
                        contenuDeMail.Contenu = (contenu != null) ? contenu : "";
                        contenuDeMail.Rebound = (rebound != null) ? rebound : "";
                    }
                    //Enregistrement de l'instance de ContenuDeMail dans l'instance de la Campagne. 
                    Home.Instance.campagne.ContenuDeMail = contenuDeMail;
                    //Vaildation du traitement
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Oups !"
                        + "\nUne erreur est survenue lors de la sauvegarde du contenu de mail."
                        + "\nVeuillez réessayer ultérieurement.");
                    Console.WriteLine(e);
                    return false;
                }
            }
            else if (!isExpediteurMail)
            {
                MessageBox.Show("Oups !"
                    + "\nL'adresse mail de l'expéditeur est invalide."
                    + "\nVeuillez vérifier l'adresse mail de l'expéditeur.");
                return false;
            }
            else if (!isReboundMail)
            {
                MessageBox.Show("Oups !"
                    + "\nL'adresse mail du rebound est invalide."
                    + "\nVeuillez vérifier l'adresse mail du rebound.");
                return false;
            }
            else
            {
                MessageBox.Show("Oups !"
                    + "\nL'adresse email de l'expéditeur et du rebound ne sont pas valides"
                    + "\nVeuillez vérifier l'adresse mail de l'expéditeur et du rebound."); 
                return false;
            }
        }

        /**
         * Vérificaiton de l'adresse mail d'un expéditeur.
         */
        private bool verifEmail(string email)
        {
            try
            {
                string regexText = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
                Regex regex = new Regex(regexText, RegexOptions.IgnoreCase);
                //-
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
