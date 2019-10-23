using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures
{
    class Lamborghini : Voiture
    {
        public override double Prix { get { return 999.99; } }

        public override string Modele { get { return "Lamborghini Urus"; } }
    }
}
