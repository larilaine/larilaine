using System;
namespace NopanheittoPäivitetty
{
    class Omat
    {
        public int Noppamaara()
        {
            int noppamaara;
            kysymys1:
            Console.WriteLine("Hei kuinka monella nopalla haluat pelata? (1-10)");
            string syote = Console.ReadLine();
            bool result = int.TryParse(syote,out noppamaara);
            if (result == false) goto kysymys1;
            if (noppamaara < 1 || noppamaara > 10) goto kysymys1;
            return noppamaara;
        }
        public int Kierrosmaara()
        {
            int kierrosmaara;
        kysymys2:
            Console.WriteLine("Hei kuinka monta kierrosta haluat pelata ?");
            string syote = Console.ReadLine();
            bool result = int.TryParse(syote, out kierrosmaara);
            if (result == false) goto kysymys2;
            return kierrosmaara;
        }
        public int Random()
        {
            Random rd = new Random();
            int random= rd.Next(1, 7);
            return random;
        }
        public int Summaaja(int alkusumma,int summa)
        {
            int palautettavasumma = alkusumma + summa;
            return palautettavasumma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei ! Tervetuloa pelaamaan Nopanheittoa");
            Omat a = new Omat();
            int summa;
            int heitonsumma;
            int kokonaissumma;
            string syote;
            int laskuri1;
            int laskuri2;
            int numero;
        alku:
            int noppamaara = a.Noppamaara();
            int kierrosmaara = a.Kierrosmaara();
            int[] nopat = new int[noppamaara];
            kokonaissumma = 0;
            summa = 0;

            for (laskuri1 = kierrosmaara; laskuri1 > 0; laskuri1--)
            {
                summa = 0;

                    for (laskuri2 = 0; laskuri2 < nopat.Length; laskuri2++)
                    {
                        numero = a.Random();
                        nopat[laskuri2] = numero;
                        Console.Write("Heitit nopalla ");
                        Console.WriteLine(" " + nopat[laskuri2]);
                    summa=a.Summaaja(nopat[laskuri2],summa);
                    }

                heitonsumma = summa;
                Console.WriteLine(" Yhteensä " + heitonsumma);
                kokonaissumma = kokonaissumma + heitonsumma;
                Console.WriteLine("sait yhteensä " + kokonaissumma);
            }
            Console.WriteLine("uudestaan? (k)");
            syote = Console.ReadLine();
            if (syote == "k" || syote == "K") goto alku;
        }
    }
}