namespace PresentationDecorateur.Classes.Pieces.Decorateurs
{
    public class Chaise : AbstractMeuble
    {
        public Chaise(AbstractPiece piece) : base(piece) { }

        public override double tarif()
        {
            return 30;
        }

        public override string type()
        {
            return "Chaise";
        }
    }
}
