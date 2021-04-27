using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Kokeilualiohjelmanumeronpalautus
{
   


    class Program
    {

        private static void Luku(out int ika)
        {
            Console.WriteLine("Anna ikasi ");
            string syote = Console.ReadLine();
            ika = int.Parse(syote);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int ika=0;
            Luku(out ika);
            Console.WriteLine("ikäsi on "+ika);
        }
    }
}
