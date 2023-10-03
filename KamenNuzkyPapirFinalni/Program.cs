using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNuzkyPapirFinalni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kámen, nůžky, papír, teď! ");
            Console.WriteLine("Zahrajeme si hru na 5 bodů - v příštím kroce napiš jednu z možností a uvidíme, kdo bude mít štěstí!");
            //Tady pouze říkám uživateli, co se bude dít


            int bodyHrac = 0;
            int bodyPocitac = 0;

            Random rnd = new Random();

            while (bodyHrac < 5 && bodyPocitac < 5)
            //Nastavuji cyklus while do té doby, než buď hráč nebo počítač nebudou mít 5 bodů
            {
                Console.WriteLine("Zadejte Kámen, Nůžky nebo Papír:");
                string vstup = Console.ReadLine();

                int vyberHrace = 0;
                if (vstup == "Kámen")
                { vyberHrace = 1; }
                else if (vstup == "Nůžky")
                { vyberHrace = 2; }
                else if (vstup == "Papír")
                { vyberHrace = 3; }
                else
                {
                    Console.WriteLine("Neplatný výraz, zkus to znovu. ");
                    continue;
                } //Zde říkám, že každá možnost hráčova vstupu má číslo

                int pocitacovaVolba = rnd.Next(1, 4);
                //Zde chci, aby si počítač vybral jednu z možností: 1 - kámen, 2 - nůžky, 3 - papír

                if (pocitacovaVolba == 1 && vyberHrace == 2)
                {
                    bodyPocitac++;
                    Console.WriteLine("Počítač vybral Kámen. Bod má počítač. ");
                }
                else if (pocitacovaVolba == 1 && vyberHrace == 3)
                {
                    bodyHrac++;
                    Console.WriteLine("Počítač vybral Kámen. Máš bod. ");
                }
                else if (pocitacovaVolba == 3 && vyberHrace == 2)
                {
                    bodyHrac++;
                    Console.WriteLine("Počítac vybral Papír. Máš bod. ");
                }
                else if (pocitacovaVolba == 2 && vyberHrace == 1)
                {
                    bodyHrac++;
                    Console.WriteLine("Počítač vybral Nůžky. Máš bod. ");
                }
                else if (pocitacovaVolba == 2 && vyberHrace == 3)
                {
                    bodyPocitac++;
                    Console.WriteLine("Počítač vybral Nůžky. Bod má počítač. ");
                }
                else if (pocitacovaVolba == 3 && vyberHrace == 1)
                {
                    bodyPocitac++;
                    Console.WriteLine("Počítač vybral Papír. Bod má počítač. ");
                }
                else if (pocitacovaVolba == vyberHrace)
                {
                    Console.WriteLine("Oba jste dali to stejné, hrajeme dál. ");
                }

                Console.WriteLine($"Body Hráč: {bodyHrac}, Body Počítač: {bodyPocitac}");
            } //Zvažuji volby hráče a počítače, podle výhry přičítám body

            if (bodyPocitac > bodyHrac)
            { Console.WriteLine("Hehe, nevyhrál jsi!"); }
            else
            { Console.WriteLine("Výborně, vyhrál jsi!"); }
            Console.ReadLine();
        }
    }
}
