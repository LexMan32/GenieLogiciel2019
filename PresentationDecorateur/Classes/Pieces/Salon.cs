namespace PresentationDecorateur.Classes.Pieces
{
    public class Salon : AbstractPiece
    {
        public Salon()
        {
            
        }

        public override double getCout()
        {
            return 0;
        }

        public override string getDescription()
        {
            return "Chambre";
        }
    }
}
