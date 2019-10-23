using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures.Options
{
    public abstract class Options : Voiture
    {
        private Voiture voitureOriginale;

        public abstract double Tarif { get; }
        public abstract string Description { get; }

        public Options (Voiture voitureOriginale)
        {
            this.voitureOriginale = voitureOriginale;
        }

        public override double Prix 
        {
            get { return voitureOriginale.Prix + Tarif; }
        }

        public override string Modele
        {
            get { return voitureOriginale.Modele + ", " + this.Description; }
        }

    }
}
