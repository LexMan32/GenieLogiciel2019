﻿using PresentationDecorateur.Classes.Pieces;
using PresentationDecorateur.Classes.Pieces.Decorateurs;
using System;

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
            AbstractPiece chambre = new Chambre();
            chambre = new Lit(chambre);
            chambre = new Armoire(chambre);
            chambre = new Etagere(chambre);
            Console.WriteLine(chambre.getDescription());
            Console.WriteLine("Prix : " + chambre.getCout());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
