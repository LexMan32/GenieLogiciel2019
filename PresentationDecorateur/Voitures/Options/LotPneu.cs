using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures.Options
{
    class LotPneu : Options
    {
        public override double Tarif { get { return 1250.00; } }

        public override string Description { get { return "Lot de pneu"; } }

        public LotPneu(Voiture voiture) : base(voiture) { }
    }
}
