using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail_v2
{
	public partial class CampaignHomeView : Form
	{

        /// <summary>
        /// Constructeur
        /// </summary>
        public CampaignHomeView(string campagneName)
        {
            InitializeComponent();
            if (MailCampView.Instance.Manager.GetCampagne != null)
            {
                // Une vérification de null est-elle obligatoire ici ?
                // Lors de l'init de CampagneManager, soit Campagne sera trouvé, soit Campagne sera créé
                labelCamapagneNameContent.Text = MailCampView.Instance.Manager.GetCampagne().Nom;
            }
            this.updateAllLabelStatuts();
        }

        /// <summary>
        /// Evènement pour le bouton d'édition de message.
        /// </summary>
        private void Message_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre d'édition de message
            CampaignMessageEditorView editionMessage = new CampaignMessageEditorView();
            //Liaison avec la page maître
            editionMessage.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            editionMessage.ShowDialog();
            //-
            //Le code suivant "ShowDialog()" est en attente de la fermture de la fenêtre
            //Vérification de la liste des emails à la fermeture de la fenêtre
            this.updateAllLabelStatuts();
        }

        /// <summary>
        /// Evènement pour le bouton de la liste des mails.
        /// </summary>
        private void Email_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre de la liste des mails
            CampaignMailsListView listeEmails = new CampaignMailsListView();
            //Liaison avec la page maître
            listeEmails.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            listeEmails.ShowDialog();
            //-
            //Le code suivant "ShowDialog()" est en attente de la fermture de la fenêtre
            //Vérification de la liste des emails à la fermeture de la fenêtre
            this.updateAllLabelStatuts();
        }

        /// <summary>
        /// Evènement pour le bouton envoi de campagne.
        /// </summary>
        private void EnvoiCampagne_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre de l'envoi de la campagne
            CampaignSendView envoiCampagne = new CampaignSendView();
            //Liaison avec la page maître
            envoiCampagne.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            envoiCampagne.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Mise à jour des labels des satuts de la campagne visible sur la page d'accueil.
        /// </summary>
        private void updateAllLabelStatuts()
        {
            //Vérification du statut de la liste des emails de la camapgne
            if (MailCampView.Instance.Manager.HasListeEmail())
            {
                this.labelConfirmEmailReady.Text = "✅ Emails prêts";
                Debug.WriteLine("[Campagne] La liste des emails de la campagne est prête.");
            }
            else
            {
                this.labelConfirmEmailReady.Text = "❌ Emails non prêts";
                Debug.WriteLine("[Campagne] La liste des emails de la campagne est prête.");
            }
            //Vérification du statut du contenu du message de la camapgne
            if (MailCampView.Instance.Manager.HasContenuValid())
            {
                this.labelConfirmMessageReady.Text = "✅ Message prêt.";
                Debug.WriteLine("[Campagne] Le contenu de la campagne est prêt.");
            }
            else
            {
                this.labelConfirmMessageReady.Text = "❌ Emails non prêt.s";
                Debug.WriteLine("[Campagne] Le contenu de la campagne est non prêt.");
            }
			//Vérification du statut de la configuration du serveur SMTP
			if (MailCampView.Instance.Manager.SMTPConnectionHandler.IsSMTPParameterValid())
			{
				this.labelConfirmServerSMTPReady.Text = "✅ Serveur SMTP prêt.";
				Debug.WriteLine("[Campagne] La campagne est prête.");
			}
			else
			{
				this.labelConfirmServerSMTPReady.Text = "❌ Serveur SMTP non prête.";
				Debug.WriteLine("[Campagne] La campagne n'est pas prête.");
			}
			//Vérification du statut de la camapgne
			if (MailCampView.Instance.Manager.HasListeEmail()
				&& MailCampView.Instance.Manager.HasContenuValid()
				&& MailCampView.Instance.Manager.SMTPConnectionHandler.IsSMTPParameterValid())
            {
                this.labelConfirmCampagneReady.Text = "✅ Campagne prête.";
                Debug.WriteLine("[Campagne] La campagne est prête.");
            }
            else
            {
                this.labelConfirmCampagneReady.Text = "❌ Campagne non prête.";
                Debug.WriteLine("[Campagne] La campagne n'est pas prête.");
            }
        }
    }
}
