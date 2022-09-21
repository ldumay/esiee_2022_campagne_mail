namespace ESIEE_2_Campagne_Mail
{
    public partial class CreerCampagne : Form
    {
        public CreerCampagne()
        {
            InitializeComponent();
        }

        private void Send_campaign_Click(object sender, EventArgs e)
        {
            string campaignName = textBox3.Text;

            if (string.IsNullOrEmpty(campaignName))
            {
                
            }
        }
    }
}