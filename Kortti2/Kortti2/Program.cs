using System;

namespace KORTTIUUSI
{
    class Program
    {
        static void Main(string[] args)
        {
            int muuntaja;
            int satunaisluku;

            string[] pakkapaikka = {
                "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a"
                ,"a","a"};

            string[] korttilista = {
                "Hertta Ässä", "Hertta 2", "Hertta 3", "Hertta 4", "Hertta 5", "Hertta 6", "Hertta 7", "Hertta 8", "Hertta 9", "Hertta 10", "Hertta Jätkä", "Herttta Kuningatar", "Hertta Kuningas",
                "Risti Ässä", "Risti 2", "Risti 3", "Risti 4", "Risti 5", "Risti 6", "Risti 7", "Risti 8", "Risti 9", "Risti 10", "Risti Jätkä", "Risti Kuningatar", "Risti Kuningas",
                "Ruutu Ässä", "Ruutu 2", "Ruutu 3", "Ruutu 4", "Ruutu 5", "Ruutu 6", "Ruutu 7", "Ruutu 8", "Ruutu 9", "Ruutu 10", "Ruutu Jätkä", "Ruutu Kuningatar", "Ruutu Kuningas",
                "Pata Ässä", "Pata 2", "Pata 3", "Pata 4", "Pata 5", "Pata 6", "Pata 7", "Pata 8", "Pata 9", "Pata 10", "Pata Jätkä", "Pata Kuningatar", "Pata Kuningas"};

            //tämä sijoittaa pakkapaikka muuttujaan satunnaisesti numerot 1-52 jokeri on aina 0 muuttujassa ja ei tule peliin.

            for (int laskuri1 = 0; laskuri1 < 500000; laskuri1++)
            {
                Random rd = new Random();
                int satunnaisluku = rd.Next(0, 52);
                if (pakkapaikka[satunnaisluku] == "a")
                {
                    Random rad = new Random();
                    int paikkaluku = rad.Next(0, 52);
                    if (korttilista[paikkaluku] == "k")
                        Console.Write("");
                    else
                    {
                        pakkapaikka[satunnaisluku] = korttilista[paikkaluku].ToString();
                        korttilista[paikkaluku] = "k";
                    }
                }
            }
            // tulostus
            for (int laskuri1 = 0; laskuri1 < 52; laskuri1++)
            {
                Console.Write(laskuri1 + "   ");
                Console.WriteLine(pakkapaikka[laskuri1]);
            }
        }







    }
}



