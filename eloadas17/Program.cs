using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyKonyv
{
    public class Konyv
    {
        long isbnszam;
        string szerzo;
        string cim;
        int megjelenes;
        string nyelv;
        bool enciklopedia;
        char ebook;
        public long Isbnszam
        {
            get { return isbnszam; }
            set { isbnszam = value;}
        }
        public string Szerzo
        {
            get { return szerzo; }
            set { szerzo = value; }
        }
        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }
        public int Megjelenes
        {
            get { return megjelenes; }
            set { megjelenes = value; }
        }
        public string Nyelv
        {
            get { return nyelv; }
            set { nyelv = value; }
        }
        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }
        public char Ebook
        {
            get { return ebook; }
            set { ebook = value; }
        }
        public Konyv(long isbnszam, string szerzo, string cim, int megjelenes, string nyelv, bool enciklopedia, char ebook)
        {
            this.isbnszam = isbnszam;
            this.szerzo = szerzo;
            this.cim = cim;
            this.megjelenes = megjelenes;
            this.nyelv = nyelv;
            this.enciklopedia = enciklopedia;
            this.ebook = ebook;
        }
        public Konyv() {}
    }
    internal class Program
    {
        /*
        static void Ertekadas()
        {
            int szerzokod = 0;
            int cimkod = 0;
            int megjeleneskod = 0;
            int nyelvkod = 0;
            int enciklopediakod = 0;
            int ebookkod = 0;
            do
            {
                Console.WriteLine("Adja meg a könyv szerző kódját!");
            } while (!int.TryParse(Console.ReadLine(), out szerzokod));
            do
            {
                Console.WriteLine("Adja meg a könyv cím kódját!");
            } while (!int.TryParse(Console.ReadLine(), out cimkod));
            do
            {
                Console.WriteLine("Adja meg a könyv megjelenési év kódját!");
            } while (!int.TryParse(Console.ReadLine(), out megjeleneskod));
            do
            {
                Console.WriteLine("Adja meg a könyv eredeti nyelv kódját!");
            } while (!int.TryParse(Console.ReadLine(), out nyelvkod));
            do
            {
                Console.WriteLine("Adja meg a könyv enciklopédia kódját!");
            } while (!int.TryParse(Console.ReadLine(), out enciklopediakod));
            do
            {
                Console.WriteLine("Adja meg a könyv elektronikus verzió kódját!");
            } while (!int.TryParse(Console.ReadLine(), out ebookkod));

            //ISBN összeállítás
            int isbnPrefix = 978;
            Console.WriteLine($"{isbnPrefix}{nyelvkod}");
        }
        */
        static void Main(string[] args)
        {
            //Ertekadas();
            string isbnszam2 = "0";
            bool joAdat = false;
            while (!joAdat)
            {
                Console.WriteLine("Adjon meg egy 10 jegyű isbn számot!");
                isbnszam2 = Console.ReadLine();
                string elso = isbnszam2.Substring(0, 1);
                string masodik = isbnszam2.Substring(1, 1);
                string harmadik = isbnszam2.Substring(2, 1);
                string negyedik = isbnszam2.Substring(3, 1);
                string otodik = isbnszam2.Substring(4, 1);
                string hatodik = isbnszam2.Substring(5, 1);
                string hetedik = isbnszam2.Substring(6, 1);
                string nyolcadik = isbnszam2.Substring(7, 1);
                string kilencedik = isbnszam2.Substring(8, 1);
                string tizedik = isbnszam2.Substring(9, 1);
                int ellenorzo = int.Parse(tizedik);
                int seged = int.Parse(elso)*1+int.Parse(masodik)*2+int.Parse(harmadik)*3+int.Parse(negyedik)*4+int.Parse(otodik)*5+int.Parse(hatodik)*6+int.Parse(hetedik)*7+int.Parse(nyolcadik)*8+int.Parse(kilencedik)*9;
                int szamoltellenorzo = seged % 11;
                if (ellenorzo == szamoltellenorzo)
                {
                    Console.WriteLine("Jó isbn számot adott meg.");
                    joAdat = true;
                }
                else
                {
                    Console.WriteLine("Rossz isbn számot adott meg.");
                    joAdat = false;
                }
            }
            Console.ReadKey();
        }
    }
}
