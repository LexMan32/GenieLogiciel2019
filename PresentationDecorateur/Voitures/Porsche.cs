/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe d'une voiture de type Porsche.
 ********************************************************************************/

namespace PresentationDecorateur.Voitures
{
    /// <summary>
    /// Classe d'une voiture de type Porsche.
    /// </summary>
    class Porsche : Voiture
    {
        /// <summary>
        /// Prix de la voiture
        /// </summary>
        public override double Prix { get { return 879.99; } }

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        public override string Modele { get { return "Porsche Taycan"; } }
    }
}
