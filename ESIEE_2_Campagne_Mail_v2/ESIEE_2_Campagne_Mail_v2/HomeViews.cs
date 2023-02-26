namespace ESIEE_2_Campagne_Mail_v2
{
    public partial class HomeViews : Form
    {
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
            // Définissez le style de bordure du formulaire à une boîte de dialogue.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Maximizer la boîte de maximisation.
            this.MaximizeBox = false;
            // Supprimer la boîte de réduction.
            this.MinimizeBox = false;
            // Définir la position de départ du formulaire au centre de l'écran.
            this.StartPosition = FormStartPosition.CenterScreen;
            // Affichez le formulaire sous la forme d'une boîte de dialogue modale.
            //this.ShowDialog();
        }
    }
}