/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe d'une voiture de type Lamborghini.
 ********************************************************************************/

namespace PresentationDecorateur.Voitures
{
    /// <summary>
    /// Classe d'une voiture de type Lamborghini.
    /// </summary>
    class Lamborghini : Voiture
    {
        /// <summary>
        /// Prix de la voiture
        /// </summary>
        public override double Prix { get { return 999.99; } }

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        public override string Modele { get { return "Lamborghini Urus"; } }
    }
}
