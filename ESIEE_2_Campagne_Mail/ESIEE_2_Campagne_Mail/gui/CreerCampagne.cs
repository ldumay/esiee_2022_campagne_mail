using ESIEE_2_Campagne_Mail.models;

namespace ESIEE_2_Campagne_Mail
{
    public partial class CreerCampagne : Form
    {
        public CreerCampagne()
        {
            InitializeComponent();
        }

        private void buttonCreateCampagneClick(object sender, EventArgs e)
        {
            // reset the warning Label content
            label2.Text = "";
            // get the input text value 
            string campaignName = textBox3.Text;

            if (!string.IsNullOrEmpty(campaignName))
            {
                // object instance home
                Home Home = new Home(new Campagne(campaignName, null, null));
                //link with the master page
                Home.Owner = this;
                //Lock the second page when it's opend
                Home.ShowDialog();
                //-
                Console.WriteLine("Campagne créée");
            }
            else
            {
                // warning message
                label2.Text = "Campaign name is not accepted";
            }
            
        }
    
    }
}