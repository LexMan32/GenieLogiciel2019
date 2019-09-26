using PresentationDecorateur.Classes.Pieces;
using PresentationDecorateur.Classes.Pieces.Decorateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Test d'utilisation des décorateurs ---------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("** Piece 1 **");
            AbstractPiece bureau = new Bureau();
            bureau = new Table(bureau);
            bureau = new Chaise(bureau);
            bureau = new Etagere(bureau);
            Console.WriteLine(bureau.getDescription());
            Console.WriteLine("Prix : " + bureau.getCout());
            Console.WriteLine();

            Console.WriteLine("** Piece 2 **");


            Console.WriteLine("** Piece 3 **");

            Console.ReadKey();
        }
    }
}
