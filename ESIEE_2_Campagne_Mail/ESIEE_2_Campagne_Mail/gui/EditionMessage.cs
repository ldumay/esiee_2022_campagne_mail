using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        /// <summary>
        /// Constructeur
        /// </summary>
        public EditionMessage()
        {
            InitializeComponent();
            this.updateEditionMessageContent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void buttonSave_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Récuprération de l'expéditeur via le champs expéditeur.
        /// </summary>
        private void textBoxEXP_TextChanged(object sender, EventArgs e)
        {
            //Home.Instance.campagne.Message.Expediteur = textBoxEXP.Text.ToString();
        }

        /// <summary>
        /// Récuprération du message via le champs message.
        /// </summary>
        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            //Home.Instance.campagne.Message.Contenu = textBoxMessage.Text.ToString();
        }

        /// <summary>
        /// Récuprération du titre via le champs titre.
        /// </summary>
        private void textBoxTitre_TextChanged(object sender, EventArgs e)
        {
            //Home.Instance.campagne.Message.Titre = textBoxTitre.Text.ToString();
        }

        /// <summary>
        /// Récuprération du rebound via le champs rebound.
        /// </summary>
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
                //-
                string message = "Le contenu du mail a bien été enregistrée.";
                MessageBox.Show(message, "Edition du contenu du mail - Enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Debug.WriteLine("[Campagne] Contenu de mail : " + Home.Instance.Manager.statutCampagneMessage);
            }
            else
            {
                string message = "Le contenu du mail n'a pas pu être enregistrée.";
                MessageBox.Show(message, "Edition du contenu du mail - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("[Campagne] Erreur lors de la sauvegarde du contenu de mail.");
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
            if (!UtilsMails.MailVerification(expediteur))
            {
                MessageBox.Show(
                    "L'adresse mail de l'expéditeur est invalide."
                    + "\nVeuillez vérifier l'adresse mail de l'expéditeur.",
                    "Oups !",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //Vérification de l'adresse mail du rebond
            if (!UtilsMails.MailVerification(rebound))
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
                Debug.WriteLine(e);
                return false;
            }

        }

        /// <summary>
        /// Vérification du contenu exsitant
        /// </summary>
        private void updateEditionMessageContent()
        {
            if(Home.Instance.Manager.GetCampagne().ContenuDeMail != null)
            {
                //Expéditeur
                if(Home.Instance.Manager.GetCampagne().ContenuDeMail.Expediteur != null)
                {
                    textBoxEXP.Text = Home.Instance.Manager.GetCampagne().ContenuDeMail.Expediteur;
                }
                //Rebound
                if (Home.Instance.Manager.GetCampagne().ContenuDeMail.Rebound != null)
                {
                    textBoxRebound.Text = Home.Instance.Manager.GetCampagne().ContenuDeMail.Rebound;
                }
                //Rebound
                if (Home.Instance.Manager.GetCampagne().ContenuDeMail.Titre != null)
                {
                    textBoxTitre.Text = Home.Instance.Manager.GetCampagne().ContenuDeMail.Titre;
                }
                //Rebound
                if (Home.Instance.Manager.GetCampagne().ContenuDeMail.Contenu != null)
                {
                    textBoxMessage.Text = Home.Instance.Manager.GetCampagne().ContenuDeMail.Contenu;
                } 
            }
        }
    }
}
