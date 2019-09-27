namespace PresentationDecorateur.Classes.Pieces.Decorateurs
{
    public abstract class AbstractMeuble : AbstractPiece
    {
        protected AbstractPiece piece;
        public abstract double tarif();
        public abstract string type();

        public AbstractMeuble(AbstractPiece piece)
        {
            this.piece = piece;
        }

        public override double getCout()
        {
            return piece.getCout() + getTarif();
        }

        public override string getDescription()
        {
            return piece.getDescription() + " : " + getType();
        }

        public double getTarif()
        {
            return tarif();
        }

        public string getType()
        {
            return type(); 
        }
    }
}
