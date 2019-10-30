/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Classe abstraite représentant une option pour une voiture.
 ********************************************************************************/

namespace PresentationDecorateur.Voitures.Options
{
    /// <summary>
    /// Classe abstraite représentant une option pour une voiture.
    /// </summary>
    public abstract class Options : Voiture
    {
        // Champ de la classe
        private Voiture voitureOriginale;

        /// <summary>
        /// Tarif de l'option
        /// </summary>
        public abstract double Tarif { get; }

        /// <summary>
        /// Description de l'option
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Constructeur d'une option
        /// </summary>
        /// <param name="voitureOriginale">Voiture d'origine</param>
        protected Options (Voiture voitureOriginale)
        {
            this.voitureOriginale = voitureOriginale;
        }

        /// <summary>
        /// Prix total de la voiture et des options
        /// </summary>
        public override double Prix 
        {
            get { return voitureOriginale.Prix + Tarif; }
        }

        /// <summary>
        /// Modele et caractéristiques de la voiture
        /// </summary>
        public override string Modele
        {
            get { return voitureOriginale.Modele + ", " + this.Description; }
        }

    }
}
