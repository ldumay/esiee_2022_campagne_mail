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
        public Campagne Campagne { get; }
        private SMTPConnectionHandler SMTPConnectionHandler { get; }

        public CampagneManager(string nomCampagne)
        {
            Campagne = new Campagne(nomCampagne);
            SMTPConnectionHandler = new SMTPConnectionHandler();
        }

        internal ContenuDeMail GetContenuDuMail()
        {
            ContenuDeMail contenuDeMail = Campagne.ContenuDeMail;
            if (contenuDeMail == null)
            {
                contenuDeMail = new ContenuDeMail();
            }
            return contenuDeMail;
        }
        internal void ChangeContenuDuMail(string? expediteur, string? titre, string? rebound, string? contenu)
        {
            expediteur ??= "";
            titre ??= "";
            contenu ??= "";
            rebound ??= "";
            Campagne.ContenuDeMail = new ContenuDeMail(expediteur, titre, rebound, contenu);
        }
    }
}
