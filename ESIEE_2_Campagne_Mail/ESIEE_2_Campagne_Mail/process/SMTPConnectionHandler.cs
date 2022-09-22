using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
    internal class SMTPConnectionHandler
    {
        private string ipAdress;
        private int port;

        public SMTPConnectionHandler()
        {
            this.ipAdress = "";
            this.port = 0;
        }

        public bool EnvoyerCampagneMail(List<string> lsiteMails)
        {
            return false;
        }
    }
}
