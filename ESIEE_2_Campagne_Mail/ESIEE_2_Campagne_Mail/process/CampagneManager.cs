using ESIEE_2_Campagne_Mail.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
    internal class CampagneManager
    {
        private Campagne campagne;
        private SMTPConnectionHandler smtpConnectionHandler;

        public CampagneManager()
        {
            this.campagne = new Campagne();
            this.smtpConnectionHandler = new SMTPConnectionHandler();
        }
    }
}
