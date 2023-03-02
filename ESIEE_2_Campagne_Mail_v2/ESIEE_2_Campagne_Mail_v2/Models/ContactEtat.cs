namespace ESIEE_2_Campagne_Mail.models
{
    /// <summary>
    /// Enumération des états d'un contact.
    /// </summary>
    public enum ContactEtat
    {
        ACTIF,
        INACTIF,
        DOUBLON,
        ERREUR_MAIL_NON_CONFORMINEE,
        ERREUR
    }
}
