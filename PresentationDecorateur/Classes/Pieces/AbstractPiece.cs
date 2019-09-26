using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces
{
    public abstract class AbstractPiece
    {
        public abstract string getDescription();

        public abstract int getTaille();

        public abstract double getCout(); 
    }
}
