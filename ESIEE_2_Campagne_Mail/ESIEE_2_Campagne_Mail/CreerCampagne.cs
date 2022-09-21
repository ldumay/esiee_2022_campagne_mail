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
            // reset the warning Label content
            label2.Text = "";
            // get the input text value 
            string campaignName = textBox3.Text;

            // check if the campaign name is empty
            if (!string.IsNullOrEmpty(campaignName))
            {
           
                // object instance home
                Home Home = new Home();
                //link with the master page
                Home.Owner = this;
                //Lock the second page when it's opend
                Home.ShowDialog();
            }
            else
            {
                // warning message
                label2.Text = "Campaign name is not accepted";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}