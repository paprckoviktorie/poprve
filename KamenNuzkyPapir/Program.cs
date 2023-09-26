using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNuzkyPapir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kámen, nůžky, papír, teď!");
            Console.WriteLine("Zahrajeme si hru - v příštím kroce napiš jednu z možností a uvidíme, kdo vyhraje!");
            Console.ReadLine();

            int bodyHrac = 0;
            int bodyPocitac = 0;

            string[] moznostiPocitace = {"Kámen","Nůžky", "Papír"};
            Random nahodnyVyber = new Random();
            int vyberPocitace = nahodnyVyber.Next(moznostiPocitace.Length);
           


            string vstup;
            vstup = Convert.ToString(Console.ReadLine());

            int vyberHrace;
            if (vstup == "Kámen")
                vyberHrace = 1;
            else if (vstup == "Nůžky")
                vyberHrace = 2;
            else if (vstup == "Papír")
                vyberHrace = 3;
            else Console.WriteLine("Neplatný výraz, zkus to znovu");
            Console.ReadLine();

            while (bodyHrac == 10 || bodyPocitac == 10);
            {
                if (vyberPocitace == 1 && vyberHrace == 2)
                    bodyPocitac++;
                else if (vyberPocitace == 1 && vyberHrace == 3)
                    bodyHrac++;
                else if (vyberPocitace == 2 && vyberHrace == 1)
                    bodyHrac++;
                else if (vyberPocitace == 2 && vyberHrace == 3)
                    bodyPocitac++;
                else if (vyberPocitace == 3 && vyberHrace == 1)
                    bodyPocitac++;

            }


        }
    }
}
