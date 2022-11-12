using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
    /// <summary>
    /// Classse SMTPConnectionHandler.
    /// </summary>
    internal class SMTPConnectionHandler
    {
        public string SMTPAddressIP { get; set; }
        public int SMTPPort { get; set; }
        public string SMTPUserLogin { get; set; }
        public string SMTPUserMDP { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public SMTPConnectionHandler()
        {
            this.SMTPAddressIP = "";
            this.SMTPPort = 0;
            this.SMTPUserLogin = "";
            this.SMTPUserMDP = "";
        }

        public bool EnvoyerCampagneMail(List<string> lsiteMails)
        {
            return false;
        }
    }
}
