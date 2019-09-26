using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces
{
    public class Bureau : AbstractPiece
    {
        public Bureau()
        {

        }

        public override double getCout()
        {
            return 0;
        }

        public override string getDescription()
        {
            return "Bureau";
        }
    }
}
