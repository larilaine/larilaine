using System;

namespace Laivanupotusilmangrafiikkaa
{

    public class Omat
    {
        public int[,] CPUampuu(int y,int x,int[,]cpukartta)
        {
            int tulitusy;
            int tulitusx;
            int[,] location=cpukartta;

            uusinta:
            Random rd1 = new Random();
            tulitusy = rd1.Next(0, 5);
            Random rd2 = new Random();
            tulitusx = rd2.Next(0, 5);
            int[,] tulitus = new int[5, 5];
            location[tulitusy, tulitusx] = 1;
            eiuusintaa:
            Console.Clear();
            Console.WriteLine("Vihollinen ampui Y = " + (tulitusy+1) + "  X = " + (tulitusx+1));
            Console.WriteLine("");
            Console.WriteLine("              ---------------------");
            Console.Write("          X5  | " + location[0, 4] + " | "); Console.Write(location[1, 4] + " | "); Console.Write(location[2, 4] + " | "); Console.Write(location[3, 4] + " | "); Console.WriteLine(location[4, 4] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X4  | " + location[0, 3] + " | "); Console.Write(location[1, 3] + " | "); Console.Write(location[2, 3] + " | "); Console.Write(location[3, 3] + " | "); Console.WriteLine(location[4, 3] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X3  | " + location[0, 2] + " | "); Console.Write(location[1, 2] + " | "); Console.Write(location[2, 2] + " | "); Console.Write(location[3, 2] + " | "); Console.WriteLine(location[4, 2] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X2  | " + location[0, 1] + " | "); Console.Write(location[1, 1] + " | "); Console.Write(location[2, 1] + " | "); Console.Write(location[3, 1] + " | "); Console.WriteLine(location[4, 1] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X1  | " + location[0, 0] + " | "); Console.Write(location[1, 0] + " | "); Console.Write(location[2, 0] + " | "); Console.Write(location[3, 0] + " | "); Console.WriteLine(location[4, 0] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("                Y1  Y2  Y3  Y4  Y5 " );
            return location;
        }

        public int[,] Pelaajaampuu(int vihollisy, int vihollisxx, int[,] omatosumat)
        {
            int[,] location = omatosumat;
            bool tark1;
            bool tark2;
            int ampumisy;
            int ampumisx;
            string syote;

            //sinä ammut
            Console.WriteLine("");
            Console.WriteLine("Mihin haluat Ampua?");
            Console.WriteLine("");
            Console.WriteLine("              ---------------------");
            Console.Write("          X5  | " + location[0, 4] + " | "); Console.Write(location[1, 4] + " | "); Console.Write(location[2, 4] + " | "); Console.Write(location[3, 4] + " | "); Console.WriteLine(location[4, 4] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X4  | " + location[0, 3] + " | "); Console.Write(location[1, 3] + " | "); Console.Write(location[2, 3] + " | "); Console.Write(location[3, 3] + " | "); Console.WriteLine(location[4, 3] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X3  | " + location[0, 2] + " | "); Console.Write(location[1, 2] + " | "); Console.Write(location[2, 2] + " | "); Console.Write(location[3, 2] + " | "); Console.WriteLine(location[4, 2] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X2  | " + location[0, 1] + " | "); Console.Write(location[1, 1] + " | "); Console.Write(location[2, 1] + " | "); Console.Write(location[3, 1] + " | "); Console.WriteLine(location[4, 1] + " | "); Console.WriteLine("              ---------------------");
            Console.Write("          X1  | " + location[0, 0] + " | "); Console.Write(location[1, 0] + " | "); Console.Write(location[2, 0] + " | "); Console.Write(location[3, 0] + " | "); Console.WriteLine(location[4, 0] + " | "); Console.WriteLine("              ---------------------");
            Console.WriteLine("                Y1  Y2  Y3  Y4  Y5 ");
        TYsyotto:
            Console.Write("   Anna Y Koordinaatti tulitukseen. (1-5) ");
            syote = Console.ReadLine();
            tark1 = int.TryParse(syote, out ampumisy);
            if (tark1 == false) goto TYsyotto;
            if (ampumisy < 1 || ampumisy > 5) goto TYsyotto;
            TXsyotto:
            Console.Write("   Anna X Koordinaatti tulitukseen. 1-5) ");
            syote = Console.ReadLine();
            tark2 = int.TryParse(syote, out ampumisx);
            if (tark2 == false) goto TXsyotto;
            if (ampumisx < 1 || ampumisx > 5) goto TXsyotto;
            ampumisy--;ampumisx--;
            int[,] tulitus = new int[5, 5];
            location[ampumisy, ampumisx] = 1;

            return location;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //muuttujat
            string syote;
            int x;
            int y;
            int vihollisx;
            int vihollisy;
            bool tark1;
            bool tark2;
        Alku:
            // vihollisen osoumien kartan nollaus
            int[,] vihollisenosumat = new int[5, 5]
          {
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
          };
            int[,] omatosumat = new int[5, 5]
         {
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
                { 0,0,0,0,0 },
         };

            Omat a = new Omat();

            // alku ja oman laivan paikan syöttö
            Console.SetWindowSize(60,46);
            Console.WriteLine("   Tervetuloa pelaamaan laivan upotusta!  ");
            Console.WriteLine("   0 = ei ole ammuttu tai osuttu");
            Console.WriteLine("   1 = ammuttu tai osuttu ruutuun ");
        Ysyotto:
            Console.WriteLine("   Valitse laivasi sijainti Y koordinaatti (1-5)");
            syote = Console.ReadLine();
            tark1 = int.TryParse(syote, out y);
            if (tark1 == false) goto Ysyotto;
            if (y < 1 || y > 5) goto Ysyotto;
            y--;
        Xsyotto:
            Console.WriteLine("   Valitse laivasi sijainti X koordinaatti (1-5)");
            syote = Console.ReadLine();
            tark2 = int.TryParse(syote, out x);
            if (tark2 == false) goto Xsyotto;
            if (x < 1 || x > 5) goto Xsyotto;
            x--;
            int[,] omansijainti = new int[5, 5];
            omansijainti[y, x] = 0;

            // vihollislaivan paikan arvonta
            Random rd1 = new Random();
            vihollisx = rd1.Next(0, 5);
            Random rd2 = new Random();
            vihollisy = rd2.Next(0, 5);
            int[,] vihollissijainti = new int[5, 5];
            vihollissijainti[vihollisy, vihollisx] = 0;

            //whileloopin sisällä pelikierrokset
            while (omansijainti[x, y] == 0 && vihollissijainti[vihollisy, vihollisx]==0)
           {
                //tietokone ampuu
                int[,] osuma = new int[5, 5];
                osuma = a.CPUampuu(y, x, vihollisenosumat);
                vihollisenosumat = osuma;
                omansijainti = osuma;

                Console.WriteLine();

                //pelaaja ampuu
                int[,] osuma2 = new int[5, 5];
                osuma2 = a.Pelaajaampuu(vihollisy, vihollisx, omatosumat);
                omatosumat = osuma2;
                vihollissijainti = osuma2;
            }

            //Ilmoitus voitosta tai häviöstä
            if (omansijainti[x, y] == 1)
            {
                Console.WriteLine("   Vastustaja upotti sinun laivasi! Hävisit");
            }
            else Console.WriteLine("   Osuit! et tullut,et nähnyt , Voitit!");


            Console.WriteLine("   Vihollislaiva oli ruudussa Y" + (vihollisy + 1) + "  X" + (vihollisx + 1));
            Console.WriteLine("   Oma laivasi oli ruudussa Y" + (y + 1) + "  X" + (x + 1));

        }
    }
}
