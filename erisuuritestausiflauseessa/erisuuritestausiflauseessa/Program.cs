using System;

namespace erisuuritestausiflauseessa
{
    class Program
    {
        static void Main(string[] args)
        {

            string syote;
            int luku;
            int arvo = 0;

        luvunsyotto:
            arvo = 0;
            Console.WriteLine("anna luku 1-10 ");
            syote = Console.ReadLine();

        tarkistus:
            if (syote == "1") { arvo = (arvo + 1); }
            if (syote == "2") { arvo = (arvo + 1); }
            if (syote == "3") { arvo = (arvo + 1); }
            if (syote == "4") { arvo = (arvo + 1); }
            if (syote == "5") { arvo = (arvo + 1); }
            if (syote == "6") { arvo = (arvo + 1); }
            if (syote == "7") { arvo = (arvo + 1); }
            if (syote == "8") { arvo = (arvo + 1); }
            if (syote == "9") { arvo = (arvo + 1); }
            if (syote == "10") { arvo = (arvo + 1); }

            Console.WriteLine(arvo);

            if (arvo < 1)
            {
                Console.WriteLine("Sinun piti antaa luku väliltä 1-10 ");
                goto luvunsyotto;
            }

            luku = Int32.Parse(syote);
            if (luku < 1 || luku > 10) goto luvunsyotto;

            Console.WriteLine("annoit luvun " + luku);
        }
    }
}
