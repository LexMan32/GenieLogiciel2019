using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces.Decorateurs
{
    public class Etagere : AbstractMeuble
    {
        public Etagere(AbstractPiece piece) : base(piece) { }

        public override double tarif()
        {
            return 120;
        }

        public override string type()
        {
            return "Etagere";
        }
    }
}
