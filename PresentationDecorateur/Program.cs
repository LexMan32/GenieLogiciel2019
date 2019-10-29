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

            Voiture client0 = new Lamborghini();
            client0 = new ToitOuvrant(client0);
            client0 = new SystemeMultimedia(client0);
            client0 = new LotPneu(client0);

            Console.WriteLine("Client 0 :");
            Console.WriteLine("\tModele : " + client0.Modele);
            Console.WriteLine("\tPrix : " + client0.Prix);

            Voiture client1 = new Ferrari();
            client1 = new Climatisation(client1);

            Console.WriteLine();

            Console.WriteLine("Client 1 :");
            Console.WriteLine("\tModele : " + client1.Modele);
            Console.WriteLine("\tPrix : " + client1.Prix);

            Console.WriteLine();

            Console.WriteLine("Le client 1 rappelle pour ajouter une option");
            client1 = new SystemeMultimedia(client1);

            Console.WriteLine("Client 1 :");
            Console.WriteLine("\tModele : " + client1.Modele);
            Console.WriteLine("\tPrix : " + client1.Prix);

            Console.ReadKey();
        }
    }
}
