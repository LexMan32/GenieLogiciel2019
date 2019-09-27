namespace PresentationDecorateur.Classes.Pieces.Decorateurs
{
    public class Table : AbstractMeuble
    {
        public Table(AbstractPiece piece) : base(piece) { }

        public override double tarif()
        {
            return 150;
        }

        public override string type()
        {
            return "Table";
        }
    }
}
