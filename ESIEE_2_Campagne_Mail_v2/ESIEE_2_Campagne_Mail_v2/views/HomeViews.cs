using FontAwesome.Sharp;

namespace ESIEE_2_Campagne_Mail_v2
{
    public partial class HomeViews : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public HomeViews()
        {
            // Chargement des composants
            InitializeComponent();
            // Chargement de la configuration de démarrage
            startConfiguration();
        }

        /// <summary>
        /// Configuration de démarrage du formulaire
        /// </summary>
        private void startConfiguration()
        {
            // Définit le style de bordure du formulaire à une boîte de dialogue.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Maximise la boîte de maximisation.
            //this.MaximizeBox = false;
            // Supprime la boîte de réduction.
            this.MinimizeBox = false;
            // Définit la position de départ du formulaire au centre de l'écran.
            this.StartPosition = FormStartPosition.CenterScreen;
            // Affiche le formulaire sous la forme d'une boîte de dialogue modale.
            //this.ShowDialog();
        }
    }
}