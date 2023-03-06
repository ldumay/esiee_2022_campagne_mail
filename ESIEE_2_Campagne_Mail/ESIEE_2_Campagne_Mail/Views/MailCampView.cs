using ESIEE_2_Campagne_Mail.Views;
using ESIEE_2_Campagne_Mail.Process;
using FontAwesome.Sharp;
using System.Diagnostics;
using static ESIEE_2_Campagne_Mail.Utils.UtilsDesign;

namespace ESIEE_2_Campagne_Mail
{
	public partial class MailCampView : Form
	{
		// - - - [Variables] - - -
		public string? campagneName;
		public readonly string campagneNameDefault = "default-name";
		private IconButton? currentBtn;
		private Panel? leftBorderBtn;
		private Form? currentChildForm;

		// - - - [Instances] - - -
		public static MailCampView? Instance;
		internal CampagneManager Manager { get; }
        /// <summary>
        /// Constructeur
        /// </summary>
        public MailCampView()
        {
			// Chargement des composants
			InitializeComponent();
			// Chargement de la configuration de démarrage
            startConfiguration(false, false, false, false, false, "center", false);
			// Préparation du gestionnaire de campagne
			Instance = this;
			if (string.IsNullOrEmpty(campagneName))
			{
				campagneName = campagneNameDefault;
			}
			Manager = new CampagneManager(campagneName);
			// Ouverture de l'accueil
			openHome();
        }

		// - - - [Methods] - - -

		/// <summary>
		/// Configuration de démarrage du formulaire.
		/// </summary>
		/// <param name="fixe"></param>
		/// <param name="maximize"></param>
		/// <param name="reduce"></param>
		/// <param name="nameApp"></param>
		/// <param name="controlBox"></param>
		/// <param name="position"></param>
		/// <param name="show"></param>
		private void startConfiguration(bool fixe, bool maximize, bool reduce, bool nameApp, bool controlBox, string position, bool show)
        {
            // Définit le style de bordure du formulaire à une boîte de dialogue.
            if (fixe)
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Maximise la boîte de maximisation.
            if (maximize)
                this.MaximizeBox = true;
            // Supprime la boîte de réduction.
            if (reduce)
                this.MinimizeBox = true;
			// Définit le texte du formulaire.
			if (nameApp)
				this.Text = string.Empty;
			// Supprime la boîte de contrôle de taille du formulaire.
			if (controlBox)
				this.ControlBox = false;
			// Définit la position de départ du formulaire au centre de l'écran.
			if (position == "center")
                this.StartPosition = FormStartPosition.CenterScreen;
            // Affiche le formulaire sous la forme d'une boîte de dialogue modale.
            if (show)
                this.ShowDialog();

            //Form
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderBtn);
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

		/// <summary>
		/// Ouverture d'un nouveau formulaire dans notre formulaire principal.
		/// </summary>
		/// <param name="childForm"></param>
		private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTopCurrentForm.Text = childForm.Text;
        }


		/// <summary>
		/// Activer un bouton si il a été cliqué.
		/// </summary>
		/// <param name="senderBtn"></param>
		/// <param name="color"></param>
		private void ActivateButton(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				DisableButton();

				//Button
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = RGBColors.color3;
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;

				//Left border button
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();

				//Current Child Form Icon
				iconPictureBoxTopCurrentForm.IconChar = currentBtn.IconChar;
				//iconPictureBoxTopCurrentForm.IconColor = color;
			}
		}

		/// <summary>
		/// Désactiver un bouton activer.
		/// </summary>
		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = RGBColors.color5;
				currentBtn.ForeColor = Color.Gainsboro;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.Gainsboro;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}

		/// <summary>
		/// Réinitialisation du formulaire principal.
		/// - Désactiver un bouton activer.
		/// - Nettoyage de vue centrale du formulaire principal.
		/// </summary>
		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
			iconPictureBoxTopCurrentForm.IconChar = IconChar.Home;
			//iconPictureBoxTopCurrentForm.IconColor = Color.MediumPurple;
			labelTopCurrentForm.Text = "Accueil";
		}

		// - - - [Events] - - -

		/// <summary>
		/// Ouverture de l'accueil dans la vue centrale du formulaire principal.
		/// </summary>
		private void openHome()
		{
			Debug.WriteLine("[Open - Button - Home]");
			//-
			OpenChildForm(new CampaignHomeView(Manager.GetCampagneName()));
		}

		/// <summary>
		/// Nettoyage de la vue centrale du formulaire principal.
		/// </summary>
		private void clear()
		{
			Debug.WriteLine("[Clear - MailCamp View]");
			//6
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			Reset();
		}

		// - - - [Click Buttons] - - -

		/// <summary>
		/// Clique sur le bouton d'accueil
		/// et nettoie la vue centrale du formulaire principal.
		/// </summary>
		private void iconButtonHome_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - Home]");
			//-
			clear();
			//-
			ActivateButton(sender, RGBColors.color1);
			openHome();
		}

		/// <summary>
		/// Clique sur le bouton de nouvelle campagne
		/// et ouvre le formulaire de création de campagne.
		/// </summary>
		private void iconButtonCampaign_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - New Campaign]");
			//-
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new CampaignNameView());
		}

		/// <summary>
		/// Clique sur le bouton de liste des mails
		/// et ouvre le formulaire de liste des mails.
		/// </summary>
		private void iconButtonMailsList_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - Mails List]");
			//-
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new CampaignMailsListView());
		}

		/// <summary>
		/// Clique sur le bouton de message de la campagne
		/// et ouvre le formulaire d'édition du message de la campagne.
		/// </summary>
		private void iconButtonCampaignMessage_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - Campaign Message]");
			//-
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new CampaignMessageEditorView());
		}

		/// <summary>
		/// Clique sur le bouton de configuration du serveur SMTP
		/// et ouvre le formulaire de configuration du serveur SMTP.
		/// </summary>
		private void iconButtonConfigSMTP_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - Config SMTP]");
			//-
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new CampaignConfigServerSMTPView());
		}

		/// <summary>
		/// Clique sur le bouton de l'envoi de la campagne
		/// et ouvre le formulaire de l'envoi de la campagne.
		/// </summary>
		private void iconButtonCampaignSend_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - Campaign Send]");
			//-
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new CampaignSendView());
		}

		/// <summary>
		/// Clique sur le bouton de à propos
		/// et ouvre le formulaire d'informations à propos de l'application.
		/// </summary>
		private void iconButtonAboutApp_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - About Appd]");
			//-
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new AboutView());
		}

		/// <summary>
		/// Clique sur le bouton de fermeture de l'application.
		/// </summary>
		private void iconButtonExitApp_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("[Click - Button - Exit App]");
			//-
			Application.Exit();
		}
	}
}