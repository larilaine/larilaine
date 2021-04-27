using System;
using System.Collections.Generic;

namespace Tehtävä23Huutokauppa
{
    public class Omat
    {
        public void Alkutervehdys()
        {
            Console.WriteLine("Hei. Tervetuloa Huutokauppa ohjelmaan.  ");
            Console.WriteLine("");
            Console.WriteLine("Ohjelma antaa käyttäjän syöttää ensin sen määrän TUOTTEITA kun käyttäjä haluaa ja TAVOITEHINNAN tuotteille ");
            Console.WriteLine("");
            Console.WriteLine("Sitten huutokaupan alkaessa käyttäjä näkee huudettavan artikkelin nimen ja sille aikaisemmin asetetun tavoitehinnan ");
            Console.WriteLine("Käyttäjä kirjaa tuotteen MYYNTIHINNAN ja ostajan HUUTONUMERON jonka jälkeen ohjelma siirtyy seuraavaan tuotteeseen");
            Console.WriteLine("");
            Console.WriteLine("Lopuksi ohjelma tulostaa kaikkien tuotteiden toteutuneet hinnat ja huutajan numeron huutokauppiaalle.");
            Console.WriteLine("Lisäksi toisen listan mistä näkee tavoitteiden ja totoeutuneiden hintojen eron ");
            Console.WriteLine("");
        }

        public int Tavoite()  //eli tällä saataisiin kokonaistavoitesumma mutta toteutin niin että laskee yksittäiset tavoitteet yhteen!
        {
        pos1:
            int luku = 0;
            string syote;
            bool oikein = true;
            Console.WriteLine("Anna huutokaupan tavoite summa numerona:");
            syote = Console.ReadLine();
            oikein = int.TryParse(syote, out luku);
            if (oikein == false) goto pos1;
            return luku;
        }

        public int Huuto()
        {
        pos1:
            int luku = 0;
            string syote;
            bool oikein = true;
            Console.WriteLine(" Anna artikkelista saatu Summa");
            syote = Console.ReadLine();
            oikein = int.TryParse(syote, out luku);
            if (oikein == false) goto pos1;
            return luku;
        }

        public int Asiakasnumero()
        {
        pos1:
            int luku = 0;
            string syote;
            bool oikein = true;
            Console.WriteLine("Anna ostajan Asiakasnumero");
            syote = Console.ReadLine();
            oikein = int.TryParse(syote, out luku);
            if (oikein == false) goto pos1;
            return luku;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Omat a = new Omat();

            int tavoite;
            int huuto;
            string artikkelinimi;
            int artikkelilaskuri=0;
            int asiakasnumero;
            int kokonaistavoite = 0;
            int kokonaissaatu = 0;

            a.Alkutervehdys();
            // tavoite = a.Tavoite(); ELI tämä kutsuisi kokonaistavoitteen jos käytössä.

            //listojen luonti
            List<string> artikkeli = new List<string>(0);
            List<int> hintatavoite = new List<int>(0);
            List<int> saatuhinta = new List<int>(0);
            List<int> asiakas = new List<int>(0);


        //Huutokaupan tuotteiden syöttö listaan ja hinta myös
        //nimen syöttö listaan
        pos1:
            Console.Write("Anna huutokaupan Artikkelin nimi tai paina (L) lopettaaksesi   ");
            artikkelinimi = Console.ReadLine();
            if (artikkelinimi == "l" || artikkelinimi == "L") goto hintasyotonlopetus;
            artikkeli.Add(artikkelinimi);
                     //hinnan syöttö listaan
            pos2:
            int hintaluku = 0;
            string syote;
            bool oikein = true;
            Console.Write("Anna artikkelin ( "+artikkelinimi+" ) tavoitesumma numeroina ");
            syote = Console.ReadLine();
            oikein = int.TryParse(syote, out hintaluku);
            if (oikein == false) goto pos2;
            hintatavoite.Add(hintaluku);
            artikkelilaskuri++;
            kokonaistavoite = kokonaistavoite + hintaluku;
            goto pos1;
        hintasyotonlopetus:


            for (int laskuri =0; laskuri < artikkelilaskuri; laskuri++)
            {
                Console.Write("Myydään " + artikkeli[laskuri] + " Tavoitehinta = " + hintatavoite[laskuri]);
                huuto = a.Huuto();
                saatuhinta.Add(huuto);
                asiakasnumero = a.Asiakasnumero();
                asiakas.Add(asiakasnumero);
                Console.WriteLine("TUOTE " + artikkeli[laskuri] + " MYYTY Hintaan = " + saatuhinta[laskuri]);
                Console.WriteLine("");
                Console.WriteLine("");
                kokonaissaatu = kokonaissaatu + huuto;
            }


            for (int laskuri = 0; laskuri < artikkelilaskuri; laskuri++)
            {
                Console.WriteLine("TUOTE=" + artikkeli[laskuri] + ",  MYYTYHINTA=" + saatuhinta[laskuri] + " , OSTAJA=" + asiakas[laskuri]);
            }
            Console.WriteLine("HUUTOKAUPASTA SAATIIN " + kokonaissaatu + " (tavoite oli " + kokonaistavoite + ")");
            if (kokonaissaatu > kokonaistavoite) Console.WriteLine("Huutokaupasta saatiin " + (kokonaissaatu - kokonaistavoite) + " enemmän kuin arvioitiin");
            if (kokonaissaatu < kokonaistavoite) Console.WriteLine("Huutokaupasta saatiin " + (kokonaistavoite - kokonaissaatu) + " vähemmän kuin arvioitiin");
        }
    }
}
