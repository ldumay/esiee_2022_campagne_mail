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
        private Campagne Campagne { get; }
        private SMTPConnectionHandler SMTPConnectionHandler { get; }

        public CampagneManager(string nomCampagne)
        {
            Campagne = new Campagne(nomCampagne);
            SMTPConnectionHandler = new SMTPConnectionHandler();
        }

        /// <summary>
        /// Ajoute le groupe de contact dans la Campagne
        /// </summary>
        /// <param name="contacts"></param>
        internal void AddGroupContact(GroupeMail contacts)
        {
            Campagne.GroupeMailList.Add(contacts);
        }

        [Obsolete("Sert juste d'entre-deux commits")]
        internal Campagne GetCampagne()
        {
            return Campagne;
        }

        [Obsolete("Sert juste d'entre-deux commits")]
        internal List<GroupeMail> GetGroupContactList()
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
