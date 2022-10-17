using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.process;

namespace ESIEE_2_Campagne_Mail
{
    public partial class Home : Form
    {
        public static Home Instance;
        internal CampagneManager Manager { get; }

        public Home(string campagneName)
        {
            InitializeComponent();
            Instance = this;
            Manager = new CampagneManager(campagneName);
            if (this.Manager.GetCampagne != null)
            {
                labelCamapagneNameContent.Text = this.Manager.GetCampagne().Nom;
            }
        }

        /**
         *  Evènement pour le bouton d'édition de message.
         */
        private void Message_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre d'édition de message
            EditionMessage editionMessage = new EditionMessage();
            //Liaison avec la page maître
            editionMessage.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            editionMessage.ShowDialog();
            //Vérification de la liste des emails à la fermeture de la fenêtre
            editionMessage.FormClosed += delegate
            {
                this.ckeckAllStatuts();
            };
        }
        
        /**
         *  Evènement pour le bouton de la liste des mails.
         */
        private void Email_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre de la liste des mails
            ListeEmails listeEmails = new ListeEmails();
            //Liaison avec la page maître
            listeEmails.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            listeEmails.ShowDialog();
            //Vérification de la liste des emails à la fermeture de la fenêtre
            listeEmails.FormClosed += delegate
            {
                this.ckeckAllStatuts();
            };
        }

        /**
         *  Evènement pour le bouton envoi de campagne.
         */
        private void EnvoiCampagne_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre de l'envoi de la campagne
            EnvoiCampagne envoiCampagne = new EnvoiCampagne();
            //Liaison avec la page maître
            envoiCampagne.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            envoiCampagne.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckeckAllStatuts()
        {
            //Vérification du statut de la liste des emails de la camapgne
            if (this.Manager.statutCampagneListeEmails == true)
            {
                this.labelConfirmEmailReady.Text = "✅ Emails prêts";
            }
            //Vérification du statut du contenu du message de la camapgne
            if (this.Manager.statutCampagneMessage == true)
            {
                this.labelConfirmMessageReady.Text = "✅ Message prêt";
            }
            //Vérification du statut de la camapgne
            if (this.Manager.statutCampagne == true)
            {
                this.labelConfirmCampagneReady.Text = "✅ Campagne prête";
            }
        }
    }
}
