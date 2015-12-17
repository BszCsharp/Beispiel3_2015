using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(156345);
            auto.Verbrauch = 8.5;
            auto.MaxFuellmenge = 80;
            //auto.KmStand = 156345;

            // Console Einstelllungen:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine(" Km-Stand vor der Fahrt: {0}", auto.KmStand);
            auto.Tanken(50);
            Console.WriteLine(" Aktuelle Füllmenge: {0} Liter\n", auto.AkuelleFuellung);
            do
            {
                int km = auto.Fahren(300);
                if (km == 300)
                {
                    Console.WriteLine(" Aktueller km-Stand {0} nach 300 km", auto.KmStand);
                    Console.WriteLine(" Aktuelle Füllmenge {0} Liter", auto.AkuelleFuellung);
                }
                else
                {
                    Console.WriteLine(" Es können nur {0} km zurückgelegt werden", km);
                    Console.WriteLine(" Aktuelle Füllmenge {0} Liter", auto.AkuelleFuellung);
                }

            } while (auto.AkuelleFuellung != 0);
          
  
           Console.Read();

        }
    }
}
