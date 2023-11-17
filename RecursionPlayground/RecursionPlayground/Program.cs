using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial} a {n}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            // TODO: Urci ukoncovaci podminku pro faktorial a zavolej Factorial zevnitr se spravnym parametrem / vypoctem.
            if (n == 1)
            {
                Console.WriteLine("Ukončovací podmínka, jsme na jedničce.");
                return 1;
            }
            Console.WriteLine($"Ještě nejsem na jedničce, zanořuju se do {n-1}");
            int nFactorial = n * Factorial(n - 1);
            /*Takže např. Factorial(5) --> nFactorial = 5Factorial(5-1) --> return 4
                */
            Console.WriteLine($"Pro {n} je nFactorial {nFactorial}");
            return nFactorial;
            // TODO: Uprav, aby Factorial vracel spravnou hodnotu.
        }

        static int Fibonacci(int n)
        {
            /*Fib(n) = Fib(n-1) + Fib(n-2)
             * n1=1
             * n2=2
             * n3=3
             * n4=5
             * n5=8
             * 1 2 3 5 8 13 21...
             */
            // TODO: Urci ukoncovaci podminku pro Fibonacciho a zavolej Fibonacci zevnitr se spravnym parametrem / vypoctem.
            if (n<=2) //nebo if (n==2|| n==1) 
            {
                return 0;
            }
            int nFibonacci = Fibonacci(n - 1) + Fibonacci(n - 2);
            return nFibonacci; // TODO: Uprav, aby Fibonacci vracel spravnou hodnotu.
        }
    }
}
