using ESIEE_2_Campagne_Mail.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESIEE_2_Campagne_Mail
{
    public partial class EnvoiCampagne : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public EnvoiCampagne()
        {
            InitializeComponent();
            this.updateAllLabelStatuts();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Bouton de lancement la configuration du serveur SMTP de la campagne.
        /// </summary>
        private void buttonConfigSMTPServer_Click(object sender, EventArgs e)
        {
            //Création de la fenêtre d'édition de message
            ConfigServerSMTP configServerSMTP = new ConfigServerSMTP();
            //Liaison avec la page maître
            configServerSMTP.Owner = this;
            //Ouverture et blocage de la vue sur la nouvelle fenêtre
            configServerSMTP.ShowDialog();
            //-
            //Le code suivant "ShowDialog()" est en attente de la fermture de la fenêtre
            //Vérification de la liste des emails à la fermeture de la fenêtre
            this.updateAllLabelStatuts();
        }
        
        /// <summary>
        /// Mise à jour des labels des satuts de la campagne visible sur la page d'accueil.
        /// </summary>
        private void updateAllLabelStatuts()
        {
            //Vérification du statut de la camapgne
            if (Home.Instance.Manager.statutCampagne == true)
            {
                this.labelConfirmCampagneReady.Text = "✅ Campagne prête";
                Debug.WriteLine("[Campagne] La campagne est prête.");
            }
            //Vérification du statut de la camapgne
            if (Home.Instance.Manager.statutSMTPServer == true)
            {
                this.labelConfirmStatutSMTP.Text = "✅ Configuration du serveur SMTP prêt";
                Debug.WriteLine("[Campagne] La campagne est prête.");
            }
        }
    }
}
