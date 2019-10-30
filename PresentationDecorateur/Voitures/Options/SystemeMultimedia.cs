/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe représentant l'option "SystemeMultimedia".
 ********************************************************************************/

namespace PresentationDecorateur.Voitures.Options
{
    /// <summary>
    /// Classe représentant l'option "SystemeMultimedia".
    /// </summary>
    class SystemeMultimedia : Options
    {
        /// <summary>
        /// Tarif de l'option
        /// </summary>
        public override double Tarif { get { return 735.00; } }

        /// <summary>
        /// Description de l'option
        /// </summary>
        public override string Description { get { return "Toit ouvrant"; } }

        /// <summary>
        /// Constructeur de l'option "SystemeMultimedia"
        /// </summary>
        /// <param name="voiture">Voiture d'origine</param>
        public SystemeMultimedia(Voiture voiture) : base(voiture) { }
    }
}
