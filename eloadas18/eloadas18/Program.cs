using eloadas18;
using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv k = new Konyv();
            /*
            bool helyes = false;
            do
            {

                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums += item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);
            */
            KonyvesPolc konyvespolc1 = new KonyvesPolc();
            try
            {
                Konyv konyv1 = new Konyv("0306406152", "Szerző1", "Cím1", 1987, "Magyar", false, 'n');
                Konyv konyv2 = new Konyv("0306406152", "Szerző1", "Cím1", 2018, "Magyar", false, 'n');
                konyvespolc1.konyvHozzaAdasa(konyv1);
                konyvespolc1.konyvHozzaAdasa(konyv2);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ISBN_NumberFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            int db = konyvespolc1.konyvekSzama;
            Console.WriteLine(db);
            Console.WriteLine(konyvespolc1.konyvekSzama);
            Console.WriteLine(konyvespolc1.konyvekSzamaFuggveny());
            Console.ReadKey();
        }
    }
}
