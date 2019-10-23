using PresentationDecorateur.Voitures;
using PresentationDecorateur.Voitures.Options;
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

            Voiture client0 = new Ferrari();

            Voiture client1 = new Ferrari();
            client1 = new Climatisation(client1);

            Console.WriteLine("Client 1 :");
            Console.WriteLine("\tModele : " + client1.Modele);
            Console.WriteLine("\tPrix : " + client1.Prix);

            Console.ReadKey();
        }
    }
}
