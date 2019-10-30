/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe représentant l'option "LotPneu".
 ********************************************************************************/

namespace PresentationDecorateur.Voitures.Options
{
    /// <summary>
    /// Classe représentant l'option "LotPneu".
    /// </summary>
    class LotPneu : Options
    {
        /// <summary>
        /// Tarif de l'option
        /// </summary>
        public override double Tarif { get { return 1250.00; } }

        /// <summary>
        /// Description de l'option
        /// </summary>
        public override string Description { get { return "Lot de pneu"; } }

        /// <summary>
        /// Constructeur de l'option "LotPneu"
        /// </summary>
        /// <param name="voiture">Voiture d'origine</param>
        public LotPneu(Voiture voiture) : base(voiture) { }
    }
}
