using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol2Dmatice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; //Sloupce
            int b; //Řádky

            Console.WriteLine("Naplníme pole čísly, které budeš chtít. Hodnoty se budou zvětšovat postupně.");

            Console.WriteLine("Zadej, kolik chceš prvků ve sloupci.");//Říkám uživateli, že má zadat, kolik chce sloupců.
            a=int.Parse(Console.ReadLine()); //Nastavuji jako vstup uživatele - to, co zadal

            Console.WriteLine("Zadej, kolik chceš prvků v řádku."); //Říkám uživateli, že má zadat, kolik chce řádků.
            b = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"Tvé pole bude tedy mít " +a * b +" prvků."); //Říkám uživateli, kolik prvků bude mít pole.
            Console.ReadLine();

            int[,] my2DArray = new int [a, b]; //Pole, které bude mít rozměry zadané uživatelem.
            int numberToAdd = 1; //Chci, aby se v každém poli hodnota zvýšila o jedno.

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    my2DArray[i, j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


            //Násobení pole číslem:
            Console.WriteLine("Chceš původní pole vynásobit nějakým číslem? Pokud ano, napiš číslo, kterým chceš pole vynásobit, pokud ne, napiš 1.");

            int multiplyNumber = int.Parse(Console.ReadLine()); //Kontroluju, zda je to uživatelovo číslo opravdu číslo, proměnnou použiju v násobení.

            if (multiplyNumber == 1)
            {
                Console.WriteLine("Ok, tvé pole zůstává stejné."); //Jestli je zadané číslo 1, dávám uživateli vědět, že to jeho pole je stále stejné.
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < my2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < my2DArray.GetLength(1); j++)
                    {
                        my2DArray[i, j] *= multiplyNumber; //Tady násobím pole tím uživatelem zvoleným číslem
                        Console.Write(my2DArray[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                Console.ReadLine();
            }


            //Vypsání řádku, který uživatel chce.
            Console.WriteLine("Napiš číslo řádku, který chceš vypsat.");
            int nRow;
            nRow = int.Parse(Console.ReadLine());
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                Console.Write(my2DArray[nRow - 1,j] + " ");
            }
            Console.Write("\n\n");


            //Vypsání sloupce, který uživatel chce.
            Console.WriteLine("Napiš číslo sloupečku, který chceš vypsat.");
            int nColumn;
            nColumn = int.Parse(Console.ReadLine());
            for (int i=0; i<my2DArray.GetLength(0);i++)
            {        
                Console.Write(my2DArray[i, nColumn-1] + " ");
            }
            Console.Write("\n\n");

            //Vypsání hlavní diagonály
            Console.WriteLine("Teď se vypíšou prvky hlavní diagonály.");
            Console.ReadLine();
            for (int i = 0; i<my2DArray.GetLength(0);i++)
            {
                Console.Write(my2DArray[i,i]+" ");
            }
            Console.Write("\n\n");


            //Prohazování prvků:
            Console.WriteLine("Teď se ti prohodí první prvky prvního řádku a druhého řádku.");
            Console.ReadLine();
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 1;
            int ySecond = 0;

            int first = my2DArray[xFirst,yFirst];
            int second = my2DArray[xSecond,ySecond];
            int temporary = first;
            my2DArray[xFirst, yFirst] = second; 
            my2DArray[xSecond, ySecond] = temporary;

            for (int i =0; i<my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


            //Prohazování řádků:
            Console.WriteLine("Teď se ti prohodí první a druhý řádek.");
            Console.ReadLine();
            int nRowSwap = 0;
            int mRowSwap = 1; 

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            { 
                int temporaryRow = my2DArray[nRowSwap, i];
                my2DArray[nRowSwap, i] = my2DArray[mRowSwap, i];
                my2DArray[mRowSwap, i] = temporaryRow;   
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


            //Prohazování sloupců:
            Console.WriteLine("Teď se ti prohodí prvky prvního a druhého sloupce.");
            Console.ReadLine();
            int nColumnSwap = 0;
            int mColumnSwap = 1;

            for (int i=0; i < my2DArray.GetLength(0); i++)
            {
                int temporaryColumn = my2DArray[i, nColumnSwap];
                my2DArray[i, nColumnSwap] = my2DArray[i, mColumnSwap];
                my2DArray[i,mColumnSwap] = temporaryColumn;
            }

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            //Otočení v hlavní diagonále.
            Console.WriteLine("Teď se ti prvky otočí v hlavní diagonále.");
            for(int i=0; i < my2DArray.GetLength(0)/2; i++)
            {
                int temporaryMainDia = my2DArray[i, i];
                int reversed = my2DArray.GetLength(0) - i - 1;
                my2DArray[i,i] =my2DArray[reversed,reversed];
                my2DArray[reversed, reversed] = temporaryMainDia;
            }

            for (int i=0;i<my2DArray.GetLength(0); i++)
            {
                for(int j=0;j<my2DArray.GetLength(1);j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            //Otočení ve vedlejší diagonále.
            Console.WriteLine("Teď se ti otočí prvky ve vedlejší diagonále.");
            Console.ReadLine();
            for(int i=0;i<my2DArray.GetLength(0)/2;i++)
            {
                int temporaryOffDia=my2DArray[i,my2DArray.GetLength(0)-i-1];
                my2DArray[i, my2DArray.GetLength(0) - i - 1] = my2DArray[my2DArray.GetLength(0) - i - 1, i];
                my2DArray[my2DArray.GetLength(0)-i-1,i] = temporaryOffDia;
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


            //Zadání druhé matice
            int c;
            int d;

            Console.WriteLine("Teď budeme přidávat další matici. Napiš, kolik chceš prvků ve sloupci.");
            c=int.Parse(Console.ReadLine());

            Console.WriteLine("A kolik chceš prvků v řádku?");
            d=int.Parse(Console.ReadLine());

            Console.WriteLine($"Dobře, tvé druhé pole bude mít " + c * d + " prvků.");
            Console.ReadLine();

            int[,] mySecond2DArray = new int[c, d]; //Pole, které bude mít rozměry zadané uživatelem.
            int secondNumberToAdd = 1; //Chci, aby se v každém poli hodnota zvýšila o jedno.

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    mySecond2DArray[i, j] = secondNumberToAdd;
                    secondNumberToAdd++;
                    Console.Write(mySecond2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


            //Násobení našich dvou matic. - při prvních krocích mi pomohl chatGPT.
            int multipliedRows= Math.Max(my2DArray.GetLength(0),mySecond2DArray.GetLength(0)); //Počítám, kolik prvků maximálně bude mít řádek.
            int multipliedColumns = Math.Max(my2DArray.GetLength(1),mySecond2DArray.GetLength(1)); //To stejné u sloupců.

            int[,] multipliedArray = new int[multipliedRows, multipliedColumns]; //Deklaruju nové pole, složené z počtu prvků delší matice.

            for (int i =0;i< multipliedRows;i++)
            {
                for (int j = 0; j < multipliedColumns; j++)
                {
                    int my2DArrayValue; 
                    if (i < my2DArray.GetLength(0) && j < my2DArray.GetLength(1)) //Chci zajistit, že když bude jedno pole delší, tak aby se zbývající prvky násobily jedničkou.
                    {
                        my2DArrayValue = my2DArray[i, j];
                    }
                    else
                    {
                        my2DArrayValue = 1;
                    }

                    int mySecond2DArrayValue;
                    if (i < mySecond2DArray.GetLength(0) && j < mySecond2DArray.GetLength(1))
                    {
                        mySecond2DArrayValue = mySecond2DArray[i, j];
                    }
                    else 
                    {
                        mySecond2DArrayValue = 1;
                    }
                    multipliedArray[i, j] = my2DArrayValue * mySecond2DArrayValue;
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            Console.WriteLine("Teď se matice vynásobí mezi sebou.");
            Console.ReadLine();

            Console.WriteLine("Zde je výsledná matice: ");
            for (int i =0; i < multipliedRows; i++)
            {
                for (int j = 0; j < multipliedColumns; j++)
                {
                    Console.Write(multipliedArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();


            //Sčítání matic.
            int summedRows = Math.Max(my2DArray.GetLength(0), mySecond2DArray.GetLength(0)); //Počítám, kolik prvků maximálně bude mít řádek.
            int summedColumns = Math.Max(my2DArray.GetLength(1), mySecond2DArray.GetLength(1)); //To stejné u sloupců.

            int[,] summedArray = new int[summedRows, summedColumns]; //Deklaruju nové pole, složené z počtu prvků delší matice.

            for (int i = 0; i < summedRows; i++)
            {
                for (int j = 0; j < summedColumns; j++)
                {
                    int my2DArrayValue;
                    if (i < my2DArray.GetLength(0) && j < my2DArray.GetLength(1)) //Chci zajistit, že když bude jedno pole delší, tak aby se nic nepřičetlo - takže 0.
                    {
                        my2DArrayValue = my2DArray[i, j];
                    }
                    else
                    {
                        my2DArrayValue = 1;
                    }

                    int mySecond2DArrayValue;
                    if (i < mySecond2DArray.GetLength(0) && j < mySecond2DArray.GetLength(1))
                    {
                        mySecond2DArrayValue = mySecond2DArray[i, j];
                    }
                    else
                    {
                        mySecond2DArrayValue = 0;
                    }
                    summedArray[i, j] = my2DArrayValue + mySecond2DArrayValue;
                }
                Console.Write("\n");
            }

            Console.WriteLine("Teď se matice sečtou.");
            Console.ReadLine();

            Console.WriteLine("Zde je výsledná matice: ");
            for (int i = 0; i < summedRows; i++)
            {
                for (int j = 0; j < summedColumns; j++)
                {
                    Console.Write(summedArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            //Odečítání matic.
            int subtractedRows = Math.Max(my2DArray.GetLength(0), mySecond2DArray.GetLength(0)); //Počítám, kolik prvků maximálně bude mít řádek.
            int subtractedColumns = Math.Max(my2DArray.GetLength(1), mySecond2DArray.GetLength(1)); //To stejné u sloupců.

            int[,] subtractedArray = new int[summedRows, summedColumns]; //Deklaruju nové pole, složené z počtu prvků delší matice.

            for (int i = 0; i < subtractedRows; i++)
            {
                for (int j = 0; j < subtractedColumns; j++)
                {
                    int my2DArrayValue;
                    if (i < my2DArray.GetLength(0) && j < my2DArray.GetLength(1)) //Chci zajistit, že když bude jedno pole delší, tak aby se nic neodečetlo - takže 0.
                    {
                        my2DArrayValue = my2DArray[i, j];
                    }
                    else
                    {
                        my2DArrayValue = 1;
                    }

                    int mySecond2DArrayValue;
                    if (i < mySecond2DArray.GetLength(0) && j < mySecond2DArray.GetLength(1))
                    {
                        mySecond2DArrayValue = mySecond2DArray[i, j];
                    }
                    else
                    {
                        mySecond2DArrayValue = 0;
                    }
                    subtractedArray[i, j] = my2DArrayValue - mySecond2DArrayValue;
                }
                Console.Write("\n");
            }

            Console.WriteLine("Teď se druhá matice odečte od první.");
            Console.ReadLine();

            Console.WriteLine("Zde je výsledná matice: ");
            for (int i = 0; i < subtractedRows; i++)
            {
                for (int j = 0; j < subtractedColumns; j++)
                {
                    Console.Write(subtractedArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

    }
}
