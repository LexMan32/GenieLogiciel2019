using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Voitures
{
    public abstract class Voiture
    {
        public abstract double Prix { get; }

        public abstract string Modele { get; }
    }
}
