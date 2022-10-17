using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.utils;
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
            if (updateContenuDeMail(textBoxEXP.Text, textBoxRebound.Text, textBoxTitre.Text, textBoxMessage.Text))
            {
                if (textBoxEXP.Text != null
                    && textBoxRebound.Text != null
                    && textBoxTitre.Text != null
                    && textBoxMessage.Text != null
                )
                {
                    Home.Instance.Manager.statutCampagneMessage = true;
                }
                Console.WriteLine("Contenu de mail : " + Home.Instance.Manager.GetContenuDuMail());
            }
            else
            {
                Console.WriteLine("Erreur lors de la sauvegarde du contenu de mail");
            }

        }

        /// <summary>
        /// Vérification et édition de l'instance de ContenuDeMail dans l'instance de la Campagne.
        /// </summary>
        /// <param name="expediteur"></param>
        /// <param name="rebound"></param>
        /// <param name="titre"></param>
        /// <param name="contenu"></param>
        /// <returns></returns>
        private bool updateContenuDeMail(string expediteur, string rebound, string titre, string contenu)
        {
            //Vérification de l'adresse mail de l'expéditeur
            if (!verifEmail(expediteur))
            {
                MessageBox.Show(
                    "L'adresse mail de l'expéditeur est invalide."
                    + "\nVeuillez vérifier l'adresse mail de l'expéditeur.",
                    "Oups !",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //Vérification de l'adresse mail du rebond
            if (!verifEmail(rebound))
            {
                MessageBox.Show(
                    "L'adresse mail du rebound est invalide."
                    + "\nVeuillez vérifier l'adresse mail du rebound.",
                    "Oups !",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            try
            {
                // Changement de ContenuDeMail
                Home.Instance.Manager.ChangerContenuDuMail(expediteur, titre, rebound, contenu);
                // Vaildation du traitement
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Une erreur est survenue lors de la sauvegarde du contenu de mail."
                    + "\nVeuillez réessayer ultérieurement.",
                    "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(e);
                return false;
            }

        }

        /// <summary>
        /// Vérificaiton de l'adresse mail d'un expéditeur.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true si l'adresse mail est valide, false sinon</returns>
        private bool verifEmail(string email)
        {
            try
            {
                Regex regex = new Regex(UtilsRegex.regexMail, RegexOptions.IgnoreCase);
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
