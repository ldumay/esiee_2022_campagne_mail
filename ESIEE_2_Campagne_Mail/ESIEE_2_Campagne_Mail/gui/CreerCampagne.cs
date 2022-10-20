using ESIEE_2_Campagne_Mail.models;
using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail
{
    public partial class CreerCampagne : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public CreerCampagne()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton de v�rification � la bonne cr�ation d'une nouvelle campagne.
        /// </summary>
        private void buttonCreateCampagneClick(object sender, EventArgs e)
        {
            // reset the warning Label content
            label2.Text = "";
            // get the input text value 
            string campaignName = textBox3.Text;
            
            if (!string.IsNullOrEmpty(campaignName))
            {
                if(this.homeCampagne == null) {
                    // object instance home
                    this.homeCampagne = new Home(campaignName);
                    //-
                    Debug.WriteLine("[Campagne] La campagne a �t� cr��. - Nom : " + campaignName);
                } else
                {
                    Debug.WriteLine("[Campagne] La campagne existe d�j�. - Nom : " + campaignName);
                }
                //link with the master page
                this.homeCampagne.Owner = this;
                //Lock the second page when it's opend
                this.homeCampagne.ShowDialog();
            }
            else
            {
                // warning message
                label2.Text = "[Campagne] La campagne n'a pas pu �tre cr�� car le nom n'est pas correcte.";
            }
            
        }
    
    }
}