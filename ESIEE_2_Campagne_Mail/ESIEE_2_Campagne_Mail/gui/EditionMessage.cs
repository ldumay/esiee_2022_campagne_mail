namespace ESIEE_2_Campagne_Mail
{
    public partial class EditionMessage : Form
    {
        public EditionMessage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        /**
         * Récuprération de l'expéditeur via le champs expéditeur.
         */
        private void textBoxEXP_TextChanged(object sender, EventArgs e)
        {
            Home.Instance.campagne.Message.Expediteur = textBoxEXP.Text.ToString();
        }

        /**
         * Récuprération du message via le champs message.
         */
        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            Home.Instance.campagne.Message.Contenu = textBoxMessage.Text.ToString();
        }

        /**
         * Récuprération du titre via le champs titre.
         */
        private void textBoxTitre_TextChanged(object sender, EventArgs e)
        {
            Home.Instance.campagne.Message.Titre = textBoxTitre.Text.ToString();
        }

        /**
         * Récuprération du rebound via le champs rebound.
         */
        private void textBoxRebound_TextChanged(object sender, EventArgs e)
        {
            Home.Instance.campagne.Message.Rebound = textBoxRebound.Text.ToString();
        }
    }
}
