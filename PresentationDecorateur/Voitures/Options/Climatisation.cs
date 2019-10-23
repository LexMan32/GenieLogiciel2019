using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures.Options
{
    class Climatisation : Options
    {
        public override double Tarif { get { return 1000.00; } }

        public override string Description { get { return "Climatisation"; } }

        public Climatisation (Voiture voiture) : base(voiture) { }
    }
}
