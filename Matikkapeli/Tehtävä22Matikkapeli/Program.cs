using System;

namespace Tehtävä22Matikkapeli
{

    public class Omat
    {
        public int Summa(int luku1, int luku2)
        {
            int tulos;
            tulos = luku1 + luku2;
            return tulos;
        }

        public int Miinus(int luku1, int luku2)
        {
            int tulos;
            tulos = luku1 - luku2;
            return tulos;
        }

        public int Kerto(int luku1, int luku2)
        {
            int tulos;
            tulos = luku1 * luku2;
            return tulos;
        }

        public decimal Jako(decimal luku1, decimal luku2)
        {
            decimal tulos;
            tulos = luku1 / luku2;
            return tulos;
        }

        public string Nimi()
        {
            string syote;
            Console.WriteLine("Kirjoita nimesi ");
            syote = Console.ReadLine();
            Console.WriteLine("Hei " + syote + " tervetuloa pelaamaan matikka peliä!");
            return syote;
        }

        public string Palkinto(decimal arvo1)
        {
            string voitto = "";
            if (arvo1 < 1) voitto = "Hylätty suoritus! Ei palkintoa.";
            if (arvo1 < 2 && arvo1 >= 1) voitto = "Vahingossa yksi oikein? sait tikkarin!";
            if (arvo1 < 3 && arvo1 >= 2) voitto = "Pari osui sait leegoja!";
            if (arvo1 < 4 && arvo1 >= 3) voitto = "Ei kolmella kuuhun mennä. Mutta ansaitsit potkulaudan!";
            if (arvo1 < 5 && arvo1 >= 4) voitto = "Neljällä voitit kissanpennun!";
            if (arvo1 < 6 && arvo1 >= 5) voitto = "puolet oikein! voitit ponin ja puoli valjaat";
            if (arvo1 < 7 && arvo1 >= 6) voitto = "kuudella ei saa kuningaskuntaa mutta palkinnoksi kultainen valtikka!";
            if (arvo1 < 8 && arvo1 >= 7) voitto = "seitsemän oikein! onneksi olkoon voitit silmarilin";
            if (arvo1 < 9 && arvo1 >= 8) voitto = "Kahdeksalla saat käkikellon!";
            if (arvo1 < 10 && arvo1 >= 9) voitto = "Yhdeksän on Kiitettävä! siis Kiitos!";
            if (arvo1 == 10) voitto = "Täydellinen suoritus! Saat Tämän maailman pallon valtaavan, vaan enhän sitä tee. Pieni voitto riittänee...";

            return voitto;
        }
        public int Valinta()
        {
        pos1:
            string syote;
            int numero = 0;
            bool oikein = true;
            Console.WriteLine("Hei mitä laskutoimituksia haluat harjoitella?");
            Console.WriteLine(" Valitse 1 = YHTEENLASKU");
            Console.WriteLine(" Valitse 2 = VÄHENNYSLASKU");
            Console.WriteLine(" Valitse 3 = KERTOLASKU");
            Console.WriteLine(" Valitse 4 = JAKOLASKU");
            syote = Console.ReadLine();
            oikein = int.TryParse(syote, out numero);
            if (oikein == false) goto pos1;
            if (numero < 1 || numero > 4) goto pos1;
            return numero;
        }

        public int Vaikeustaso()
        {
        pos1:
            string syote;
            int numero = 0;
            int numero2 = 0;
            bool oikein = true;
            Console.WriteLine("Hei Valitse vaikeustaso");
            Console.WriteLine(" Valitse 1 = luvuilla 1-10");
            Console.WriteLine(" Valitse 2 = luvuilla 1-20");
            Console.WriteLine(" Valitse 3 = luvuilla 1-30");
            Console.WriteLine(" Valitse 4 = luvuilla 1-40");
            syote = Console.ReadLine();
            oikein = int.TryParse(syote, out numero);
            if (oikein == false) goto pos1;
            if (numero < 1 || numero > 4) goto pos1;
            if (numero == 1) numero2 = 11;
            if (numero == 2) numero2 = 21;
            if (numero == 3) numero2 = 31;
            if (numero == 4) numero2 = 41;
            return numero2;
        }
      
        class Program
        {

            static void Main(string[] args)
            {

                Omat a = new Omat();
                a.Nimi(); //sisältää alkutervehdyksen
                int val = a.Valinta();
                int vaik =a.Vaikeustaso();
                string syote;
                bool oikein;
                int numero;
                decimal pisteet = 0;
                int laskuri;
                int num1;
                int num2;

                Random rd = new Random(1 - (vaik));
                switch (val)
            {
                    case 1:
                    {
                            for (int luku = 1; luku < 11; luku++)
                            {
                                num1 = rd.Next(1, vaik);
                                num2 = rd.Next(1, vaik);
                                int oikea = a.Summa(num1, num2);
                            pos2:
                                Console.WriteLine("Paljonko on " + num1 + " ja " + num2 + " Yhteensä?");
                                syote = Console.ReadLine();
                                oikein = int.TryParse(syote, out numero);
                                if (oikein == false) goto pos2;

                                Console.WriteLine("Vastasit "+numero+"  oikea vastaus oli " + oikea);
                                if (numero == oikea)
                                {
                                    pisteet++;
                                }
                            }
                    } break;

                    case 2:
                        {
                            for (int luku = 1; luku < 11; luku++)
                            {
                                num1 = rd.Next(1, vaik);
                                num2 = rd.Next(1, vaik);
                                int oikea = a.Miinus(num1, num2);
                            pos2:
                                Console.WriteLine("Paljonko on " + num1 + " Miinus " + num2 + " ?");
                                syote = Console.ReadLine();
                                oikein = int.TryParse(syote, out numero);
                                if (oikein == false) goto pos2;

                                Console.WriteLine("Vastasit " + numero + "  oikea vastaus oli " + oikea);
                                if (numero == oikea)
                                {
                                    pisteet++;
                                }
                            }
                        }
                        break;

                    case 3:
                        {
                            for (int luku = 1; luku < 11; luku++)
                            {
                                num1 = rd.Next(1, vaik);
                                num2 = rd.Next(1, vaik);
                                int oikea = a.Kerto(num1, num2);
                            pos2:
                                Console.WriteLine("Paljonko on " + num1 + " ja " + num2 + " Kerrottuna?");
                                syote = Console.ReadLine();
                                oikein = int.TryParse(syote, out numero);
                                if (oikein == false) goto pos2;

                                Console.WriteLine("Vastasit " + numero + "  oikea vastaus oli " + oikea);
                                if (numero == oikea)
                                {
                                    pisteet++;
                                }
                            }
                        }
                        break;

                    case 4:
                        {
                            for (int luku = 1; luku < 11; luku++)
                            {
                                num1 = rd.Next(1, vaik);
                                num2 = rd.Next(1, vaik);
                                decimal oikea = a.Jako(num1, num2);
                            pos2:
                                Console.WriteLine("Paljonko on " + num1 + " jaettuna luvulla " + num2 + " ?");
                                syote = Console.ReadLine();
                                oikein = decimal.TryParse(syote, out decimal numero2);
                                if (oikein == false) goto pos2;

                                Console.WriteLine("Vastasit " + numero2 + "  oikea vastaus oli " + oikea);
                                if (numero2 == oikea)
                                {
                                    pisteet++;
                                }
                            }
                        }
                        break;
                }
                string palkintoteksti = a.Palkinto(pisteet);
                Console.WriteLine("");
                Console.WriteLine(palkintoteksti);
            }
        }
    }
}
