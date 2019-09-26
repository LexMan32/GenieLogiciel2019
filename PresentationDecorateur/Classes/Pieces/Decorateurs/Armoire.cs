using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces.Decorateurs
{
    public class Armoire : AbstractMeuble
    {
        public Armoire(AbstractPiece piece) : base(piece) { }

        public override double tarif()
        {
            return 170;
        }

        public override string type()
        {
            return "Armoire";
        }
    }
}
