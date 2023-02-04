namespace ESIEE_2_Campagne_Mail_v2
{
    public partial class MailCamp : Form
    {
        List<Panel> listPanel = new List<Panel>();

        /// <summary>
        /// Constructeur
        /// </summary>
        public MailCamp()
        {
            // Chargement des composants
            InitializeComponent();
            // Chargement de la configuration de démarrage
            startConfiguration();
            // Chargement des panels
            loadPanels();
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

        /// <summary>
        /// Configuration des panels
        /// </summary>
        private void loadPanels() {
            // Masquage des panels
            panelHome.Hide();
            
            // Taille complète du panel
            panelHome.Dock = DockStyle.Fill;
            // Centralisation du panel
            panelHome.Location = new Point(0, 0);
            // Fond transparent du panel à 10
            panelHome.BackColor = Color.FromArgb(10, 0, 0, 0);

            // Ajout des panels dans la liste
            listPanel.Add(panelHome);

            // Afficher le panel de démarrage
            panelHome.Show();
        }

        private void buttonNomDeLaCampagneClick(object sender, EventArgs e){}
    }
}