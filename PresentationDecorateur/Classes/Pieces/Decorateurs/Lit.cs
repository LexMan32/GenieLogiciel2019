using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces.Decorateurs
{
    public class Lit : AbstractMeuble
    {
        public Lit(AbstractPiece piece) : base(piece) { }

        public override double tarif()
        {
            return 250;
        }

        public override string type()
        {
            return "Lit";
        }
    }
}
