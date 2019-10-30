/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe représentant l'option "Climatisation".
 ********************************************************************************/

namespace PresentationDecorateur.Voitures.Options
{
    /// <summary>
    /// Classe représentant l'option "Climatisation".
    /// </summary>
    class Climatisation : Options
    {
        /// <summary>
        /// Tarif de l'option
        /// </summary>
        public override double Tarif { get { return 1000.00; } }

        /// <summary>
        /// Description de l'option
        /// </summary>
        public override string Description { get { return "Climatisation"; } }

        /// <summary>
        /// Constructeur de l'option "Climatisation"
        /// </summary>
        /// <param name="voiture">Voiture d'origine</param>
        public Climatisation (Voiture voiture) : base(voiture) { }
    }
}
