using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures.Options
{
    class ToitOuvrant : Options
    {
        public override double Tarif { get { return 1550.00; } }

        public override string Description { get { return "Toit ouvrant"; } }

        public ToitOuvrant(Voiture voiture) : base(voiture) { }
    }
}
