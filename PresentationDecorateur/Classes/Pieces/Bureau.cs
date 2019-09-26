using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces
{
    public class Bureau : AbstractPiece
    {
        public override double getCout()
        {
            return 0;
        }

        public override string getDescription()
        {
            return "Bureau";
        }

        public override int getTaille()
        {
            return 20;
        }
    }
}
