using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures.Options
{
    class SystemeMultimedia : Options
    {
        public override double Tarif { get { return 735.00; } }

        public override string Description { get { return "Toit ouvrant"; } }

        public SystemeMultimedia(Voiture voiture) : base(voiture) { }
    }
}
