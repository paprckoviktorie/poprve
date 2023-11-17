using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mojePenize = 10000; //já i počítač máme 10 000$
            int pocitacovyPenize = 10000;

            Console.WriteLine($"Zahrajeme si Deathroll. Zatím máš {mojePenize} $. Můžeš si tedy vybrat číslo od 1 do {mojePenize}. Následně si počítač vybere číslo od 1 do Tvého vybraného čísla. Takhle to půjde až do doby, kdy jeden z vás nebude mít 1 $. Buď vsazenou částku vyhraješ nebo prohraješ. Hra končí, když jeden z vás dosáhne 1 $");
            Console.WriteLine("Napiš částku.");
            Console.ReadLine();

            Random rnd = new Random();

            while (mojePenize>1 ||pocitacovyPenize>1)
            {
                string vstup = Console.ReadLine();
                int.TryParse(vstup, out int vybranaCastka);

                if (vybranaCastka > 1 && vybranaCastka < mojePenize)
                {
                    Console.WriteLine($"Skvělé, vybral jsi {vybranaCastka},to se nachází v intervalu. Teď hraje počítač.");
                    Console.ReadLine();
                    int pocitacovaVolba = rnd.Next(1, vybranaCastka); //počítač si vybírá částku mezi 1 a mým zůstatkem
                    Console.WriteLine($"Počítač si vybral {pocitacovaVolba}.");
                    Console.ReadLine();
                }

                else if (vybranaCastka < 1 || vybranaCastka < mojePenize)
                {
                    Console.WriteLine("To není přípustná částka pro roll, zkus to znovu");
                    Console.ReadLine();
                }


                

                

            }

            Console.WriteLine($"Teď máš:{mojePenize}$.");
            Console.ReadLine();
        }
    }
}
