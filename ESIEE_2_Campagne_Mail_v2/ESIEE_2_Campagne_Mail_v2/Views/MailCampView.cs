using ESIEE_2_Campagne_Mail;
using FontAwesome.Sharp;
using System.Diagnostics;
using static ESIEE_2_Campagne_Mail_v2.utils.UtilsDesign;

namespace ESIEE_2_Campagne_Mail_v2
{
    public partial class MailCampView : Form
    {
        // - - - [Variables] - - -
        private IconButton? currentBtn;
        private Panel? leftBorderBtn;
        private Form? currentChildForm;
        
        /// <summary>
        /// Constructeur
        /// </summary>
        public MailCampView()
        {
            // Chargement des composants
            InitializeComponent();
            // Chargement de la configuration de d�marrage
            startConfiguration(true, true, true, "center", false);
            // Surcharge du formulaire
            initForm();
        }

        // - - - [Methods] - - -

        /// <summary>
        /// Configuration de d�marrage du formulaire.
        /// </summary>
        private void startConfiguration(bool fixe, bool maximize, bool reduce, string position, bool show)
        {
            // D�finit le style de bordure du formulaire � une bo�te de dialogue.
            if (fixe)
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Maximise la bo�te de maximisation.
            if (maximize)
                this.MaximizeBox = true;
            // Supprime la bo�te de r�duction.
            if (reduce)
                this.MinimizeBox = true;
            // D�finit la position de d�part du formulaire au centre de l'�cran.
            if (position == "center")
                this.StartPosition = FormStartPosition.CenterScreen;
            // Affiche le formulaire sous la forme d'une bo�te de dialogue modale.
            if (show)
                this.ShowDialog();
        }

        /// <summary>
        /// Surcharge du formulaire
        /// </summary>
        private void initForm()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /// <summary>
        /// Ouverture d'un nouveau formulaire dans notre formulaire principal.
        /// </summary>
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
        /// Activer un bouton si il a �t� cliqu�.
        /// </summary>
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
        /// D�sactiver un bouton activer.
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
        /// R�initialisation du formulaire principal.
        /// - D�sactiver un bouton activer.
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

        // - - - [Events Buttons] - - -

        /// <summary>
        /// Clique sur le bouton d'accueil.
        /// </summary>
        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("[Click - Button - Home]");
            //-
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        /// <summary>
        /// Clique sur le bouton de nouvelle campagne.
        /// </summary>
        private void iconButtonCampaign_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("[Click - Button - New Campaign]");
            //-
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CreateCampaignView());
        }
    }
}