using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.process;
using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail
{
	public partial class Home : Form
	{
		public static Home Instance;
		internal CampagneManager Manager { get; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Home(string campagneName)
        {
            InitializeComponent();
            Instance = this;
            Manager = new CampagneManager(campagneName);
            if (this.Manager.GetCampagne != null)
            {
                // Une vérification de null est-elle obligatoire ici ?
                // Lors de l'init de CampagneManager, soit Campagne sera trouvé, soit Campagne sera créé
                labelCamapagneNameContent.Text = this.Manager.GetCampagne().Nom;
            }
            this.updateAllLabelStatuts();
        }

        /// <summary>
        /// Evènement pour le bouton d'édition de message.
        /// </summary>
        private void Message_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre d'édition de message
            EditionMessage editionMessage = new EditionMessage();
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
            ListeEmails listeEmails = new ListeEmails();
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
            EnvoiCampagne envoiCampagne = new EnvoiCampagne();
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
            if (this.Manager.statutCampagneListeEmails == true)
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
            if (this.Manager.statutCampagneMessage == true)
            {
                this.labelConfirmMessageReady.Text = "✅ Message prêt";
                Debug.WriteLine("[Campagne] Le contenu de la campagne est prêt.");
            }
            else
            {
                this.labelConfirmMessageReady.Text = "❌ Emails non prêts";
                Debug.WriteLine("[Campagne] Le contenu de la campagne est non prêt.");
            }
            //Vérification du statut de la liste des emails et du statut du contenu du message de la camapgne
            if (Home.Instance.Manager.statutCampagneListeEmails
                && Home.Instance.Manager.statutCampagneMessage
            )
            {
                Home.Instance.Manager.statutCampagne = true;
            }
            else
            {
                Home.Instance.Manager.statutCampagne = false;
            }
            //Vérification du statut de la camapgne
            if (this.Manager.statutCampagne == true)
            {
                this.labelConfirmCampagneReady.Text = "✅ Campagne prête";
                Debug.WriteLine("[Campagne] La campagne est prête.");
            }
            else
            {
                this.labelConfirmCampagneReady.Text = "❌ Campagne non prête";
                Debug.WriteLine("[Campagne] La campagne n'est pas prête.");
            }
        }
    }
}
