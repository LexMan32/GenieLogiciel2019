/********************************************************************************
 * Auteur           Alexandre Morel & Dylan Lack
 * Nom de l'app     GenieLogiciel2019 - PresentationDecorateur
 * Version          1.0
 * Description:     Permet de démontrer l'utilité du Design Pattern "Décorateur".
 ********************************************************************************/

using PresentationDecorateur.Voitures;
using PresentationDecorateur.Voitures.Options;
using System;

namespace PresentationDecorateur
{
    class Program
    {
        /// <summary>
        /// Point d'entré du programme.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Affichage de l'en-tête
            Console.WriteLine("--------- Test d'utilisation des décorateurs ---------");
            Console.WriteLine();
            Console.WriteLine();

            // Déclaration de la voiture Client0
            Voiture client0 = new Lamborghini();
            client0 = new ToitOuvrant(client0);
            client0 = new SystemeMultimedia(client0);
            client0 = new LotPneu(client0);

            // Affichage de la voiture Client0
            Console.WriteLine("Client 0 :");
            Console.WriteLine("\tModele : " + client0.Modele);
            Console.WriteLine("\tPrix : " + client0.Prix);
            Console.WriteLine();

            // Déclaration de la voiture Client1
            Voiture client1 = new Ferrari();
            client1 = new Climatisation(client1);

            // Affichage de la voiture Client1
            Console.WriteLine("Client 1 :");
            Console.WriteLine("\tModele : " + client1.Modele);
            Console.WriteLine("\tPrix : " + client1.Prix);
            Console.WriteLine();

            // Ajout d'une option pour le client 1
            Console.WriteLine("Le client 1 rappelle pour ajouter une option");
            Console.WriteLine();
            client1 = new SystemeMultimedia(client1);

            // Affichage de la voiture Client1
            Console.WriteLine("Client 1 :");
            Console.WriteLine("\tModele : " + client1.Modele);
            Console.WriteLine("\tPrix : " + client1.Prix);

            // Attente de la fermeture du programme
            Console.ReadKey();
        }
    }
}
