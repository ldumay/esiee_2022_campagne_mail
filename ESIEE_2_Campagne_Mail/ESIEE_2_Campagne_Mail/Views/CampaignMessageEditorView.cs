using ESIEE_2_Campagne_Mail.Models;
using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail
{
    public partial class CampaignMessageEditorView : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public CampaignMessageEditorView()
        {
            InitializeComponent();
            this.updateEditionMessageContent();
        }

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


        /// <summary>
        /// Vérification et changement du ContenuDeMail dans la Campagne.
        /// </summary>
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Changement de ContenuDeMail
                MailCampView.Instance.Manager.ChangerContenuDuMail(textBoxEXP.Text, textBoxTitre.Text, textBoxRebound.Text, textBoxMessage.Text);
                //-
                string message = "Le contenu du mail a bien été enregistrée.";
                MessageBox.Show(message, "Edition du contenu du mail - Enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Debug.WriteLine("[Campagne] Contenu de mail : " + MailCampView.Instance.Manager.statutCampagneMessage);
            }
            catch (Exception err)
            {
                Debug.WriteLine("[Campagne] Erreur lors de la sauvegarde du contenu de mail.");
                Debug.WriteLine(err.Message);
                MessageBox.Show(
                    "Le contenu du mail n'a pas pu être enregistrée."
                    + "\n" + err.Message
                    + "\nVeuillez réessayer ultérieurement.",
                    "Edition du contenu du mail - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Vérification du contenu exsitant
        /// </summary>
        private void updateEditionMessageContent()
        {
            ContenuDeMail contenuMail = MailCampView.Instance.Manager.GetContenuDuMail();
            // Expéditeur
            textBoxEXP.Text = contenuMail.Expediteur ?? string.Empty;
            // Rebound
            textBoxRebound.Text = contenuMail.Rebound ?? string.Empty;
            // Titre
            textBoxTitre.Text = contenuMail.Titre ?? string.Empty;
            // Contenu
            textBoxMessage.Text = contenuMail.Contenu ?? string.Empty;
        }
    }
}
