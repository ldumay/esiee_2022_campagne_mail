using ESIEE_2_Campagne_Mail.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
    /// <summary>
    /// Classse CampagneManager.
    /// </summary>
    internal class CampagneManager
    {
        private Campagne Campagne { get; }
        /// <summary>
        /// Attribut de la Campagne
        /// </summary>
        private SMTPConnectionHandler SMTPConnectionHandler { get; }
        /// <summary>
        /// Attribut du SMTPConnectionHandler
        /// </summary>
        public Boolean statutCampagneListeEmails { get; set; }
        /// <summary>
        /// Attribut du statut de la liste des mails de la campagne
        /// </summary>
        public Boolean statutCampagneMessage { get; set; }
        /// <summary>
        /// Attribut du statut du message de la campagne
        /// </summary>
        public Boolean statutCampagne { get; set; }
        /// <summary>
        /// Attribut du statut de la campagne
        /// </summary>
        public Boolean statutSendReady { get; set; }
        /// <summary>
        /// Attribut du statut de l'envoi de la campagne
        /// </summary>
        public Boolean statutSMTPServer { get; set; }
        /// <summary>
        /// Attribut du statut de l'envoi de la campagne
        /// </summary>

        public CampagneManager(string nomCampagne)
        {
            Campagne = new Campagne(nomCampagne);
            SMTPConnectionHandler = new SMTPConnectionHandler();
        }

        /// <summary>
        /// Ajoute le groupe de contact dans la Campagne
        /// </summary>
        /// <param name="contacts"></param>
        internal void AddGroupContact(GroupeContact contacts)
        {
            Campagne.GroupeMailList.Add(contacts);
        }

        [Obsolete("Sert juste d'entre-deux commits")]
        internal Campagne GetCampagne()
        {
            return Campagne;
        }
        
        [Obsolete("Sert juste d'entre-deux commits")]
        internal SMTPConnectionHandler GetSMTPConnectionHandler()
        {
            return SMTPConnectionHandler;
        }

        [Obsolete("Sert juste d'entre-deux commits")]
        internal List<GroupeContact> GetGroupContactList()
        {
            return Campagne.GroupeMailList;
        }

        /// <summary>
        /// Retourne le contenu du mail de la Campagne actuelle
        /// </summary>
        /// <returns></returns>
        internal ContenuDeMail GetContenuDuMail()
        {
            ContenuDeMail contenuDeMail = Campagne.ContenuDeMail ?? new ContenuDeMail();
            return contenuDeMail;
        }

        /// <summary>
        /// Change le contenu du message envoyé
        /// </summary>
        /// <param name="expediteur"></param>
        /// <param name="titre"></param>
        /// <param name="rebound"></param>
        /// <param name="contenu"></param>
        internal void ChangerContenuDuMail(string? expediteur, string? titre, string? rebound, string? contenu)
        {
            ContenuDeMail contenuDeMail = GetContenuDuMail();
            expediteur = string.IsNullOrEmpty(expediteur) ? contenuDeMail.Expediteur : expediteur;
            titre = string.IsNullOrEmpty(titre) ? contenuDeMail.Titre : titre;
            contenu = string.IsNullOrEmpty(contenu) ? contenuDeMail.Contenu : contenu;
            rebound = string.IsNullOrEmpty(rebound) ? contenuDeMail.Rebound : rebound;
            Campagne.ContenuDeMail = new ContenuDeMail(expediteur, titre, rebound, contenu);
        }
    }
}
