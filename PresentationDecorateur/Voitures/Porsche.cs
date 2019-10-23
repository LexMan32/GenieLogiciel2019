using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures
{
    class Porsche : Voiture
    {
        public override double Prix { get { return 879.99; } }

        public override string Modele { get { return "Porsche Taycan"; } }
    }
}
