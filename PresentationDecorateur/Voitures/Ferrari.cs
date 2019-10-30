/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe d'une voiture de type Ferrari.
 ********************************************************************************/

namespace PresentationDecorateur.Voitures
{
    /// <summary>
    /// Classe d'une voiture de type Ferrari.
    /// </summary>
    class Ferrari : Voiture
    {
        /// <summary>
        /// Prix de la voiture
        /// </summary>
        public override double Prix { get { return 749.99; } }

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        public override string Modele { get { return "Ferrari 308"; } }
    }
}
