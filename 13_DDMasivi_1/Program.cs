using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DDMasivi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet rindu skaitu: ");
            int rinduSkaits = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet kolonnu skaitu: ");
            int kolonnuSkaits = int.Parse(Console.ReadLine());

            int[,] masivs = new int[rinduSkaits, kolonnuSkaits];

            Random rand = new Random();
            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    masivs[i, j] = rand.Next(1, 101);
                }
            }

            Console.WriteLine("Sākotnējais masīvs:");
            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    Console.Write($"{masivs[i, j],4} ");
                }
                Console.WriteLine();
            }

            int paruSkaitluSkaits = 0;
            int kopSkaitluSkaits = rinduSkaits * kolonnuSkaits;

            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    if (masivs[i, j] % 2 == 0)
                    {
                        paruSkaitluSkaits++;
                    }
                }
            }

            double procenti = (paruSkaitluSkaits / (double)kopSkaitluSkaits) * 100;

            Console.WriteLine();
            Console.WriteLine($" {procenti}% no masīva elementiem ir para skaitli!");
            Console.WriteLine();

            // Pieskaita 1 visiem pāra skaitļiem
            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    if (masivs[i, j] % 2 == 0)
                    {
                        masivs[i, j]++;
                    }
                }
            }

            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    Console.Write($"{masivs[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    }
}