/**************************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe abstraite représentant les caractéristiques d'une voiture.
 **************************************************************************************/

namespace PresentationDecorateur.Voitures
{
    /// <summary>
    /// Classe abstraite représentant les caractéristiques d'une voiture.
    /// </summary>
    public abstract class Voiture
    {
        /// <summary>
        /// Prix de la voiture
        /// </summary>
        public abstract double Prix { get; }

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        public abstract string Modele { get; }
    }
}
