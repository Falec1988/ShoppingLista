using System;
using System.Collections;

namespace ShoppingLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList za shopping listu
            ArrayList shoppingLista = new ArrayList();

            // Korisnik unosi stavke dok ne unese 'kraj'
            Console.WriteLine("Unesite stavke na shopping listu (ili 'kraj' za završetak unosa):");
            while (true)
            {
                string unos = Console.ReadLine();
                if (unos.ToLower() == "kraj")
                    break;

                shoppingLista.Add(unos);
            }

            // Ispis shopping liste koristeći foreach
            Console.WriteLine("Shopping lista:");
            foreach (var stavka in shoppingLista)
            {
                Console.WriteLine("- " + stavka);
            }

            Console.ReadLine();
        }
    }
}
