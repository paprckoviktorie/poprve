using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = { 10, 20, 30, 40, 50 };


            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Vypsání for cyklem:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i + 1]);
            }
            Console.WriteLine("\nVypsání foreachem:");

            foreach (int number in myArray) //Jde pro každou hodnotu v poli; pro každou iteraci potřebuju proměnnou number, se kterou pracuju - to stejné jako u for cyklu - ale u for cyklu můžu jet různé podmínky, foreach prostě jede odzvrchu dolu
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum -= myArray[i];
            }


            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = 0;
            average = (sum / myArray.Length);
            Console.WriteLine("Průměr: " + average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = 0;
            max = myArray.Max();
            Console.WriteLine("Maximum: " + max);


            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = int.MaxValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine("Minimum: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            //30 je na indexu 3 NEBO 30 není v poli
            int userNumber = int.Parse(Console.ReadLine());
            bool foundNumber = false;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (userNumber == myArray[i])
                {
                    foundNumber = true;
                    Console.WriteLine($"Hledané číslo: {userNumber}je na indexu {i} ");
            break;
        }
            }
  

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rng = new Random();
            myArray = new int[100];
            for (int i =0; i< myArray.Length; i++)
            {
                myArray[i] = rng.Next(0,10);
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole. --> počet výskytů podle indexů
            int[] counts = new int[10];
            foreach(int number in myArray)
            {
                counts[number]++;
            }

            for (int i=0; i<counts.Length; i++)
            {
                Console.WriteLine($"Číslo {i} se vyskytuje {counts[i]} krát. ");
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] mySecondArray = new int[100];
            for (int i = mySecondArray.Length-1; i>=0; i--) //-1, protože se indexuje od nuly
            {
                mySecondArray[i] = myArray[99- i];
            }

            /*nebo
             * for (int i = myArray.Length - 1; i>=0; i--)
             * {to same}
             */

            Console.WriteLine("První pole.");
            foreach(int number in mySecondArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Druhé pole.");

            Console.ReadKey();
        }
    }
}
