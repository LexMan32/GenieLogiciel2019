using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures
{
    class Ferrari : Voiture
    {
        public override double Prix { get { return 749.99; } }

        public override string Modele { get { return "308"; } }
    }
}
