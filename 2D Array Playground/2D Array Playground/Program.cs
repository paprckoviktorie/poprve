using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            //i=řádky, j=sloupce
            int[,] my2DArray = new int[5, 5];
            int numberToAdd = 1;
            for(int i = 0; i <my2DArray.GetLength(0); i++) //nemůžu my2DArray.Length, protože to není 5, ale 25
            {
                for (int j =0; j <my2DArray.GetLength(1); j++)
                {
                    my2DArray[i, j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            for (int j = 0; j<my2DArray.GetLength(1); j++)
            {
                Console.Write(my2DArray[nRow,j] + " "); //nRow se nemění, je to pořád na tom , co chci, jen to j se bude měnit, můžu nastavit, na co chcu
            }
            Console.Write("\n");

            //BONUS TODO: vypiš do konzole prvky na hlavní diagonále (pak vedlejší diagonála)
                //stačí mi jeden cyklus, protože i=j
            for (int i = 0; i <my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i,i]+ " ");
            }
        Console.Write("\n");

            //BONUS TODO NO2: vedlejší diagonála 4,0; 3,1; 2,2; 1,3;0,4
            for (int i = 4; i >=0; i--)
            {
                Console.Write(my2DArray[i, my2DArray.GetLength(0)-i-1] + " "); //od velikosti pole odčitáme zmenšující se i
            }
            Console.Write("\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i, nColumn] + " ");
            }

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 1;
            int ySecond = 1;
          //  int first = my2DArray[xFirst, yFirst];
          // int second = my2DArray[xSecond, ySecond];

            int temp = my2DArray[xFirst,yFirst]; //temp jako temporary
            my2DArray[xFirst, yFirst] = my2DArray[xSecond,ySecond];
            my2DArray[xSecond, ySecond] = temp;

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;

            for (int i = 0;i< my2DArray.GetLength(0);i++)
            {
                for (int j = 0;j < my2DArray.GetLength(1);j++)
                {
                    Console.Write(my2DArray[i, j] + "");
                }
                Console.Write("\n");
   
            }

            
            int nColSwap = 0;
            int mColSwap = 1;

            int[] tempArray = new int[5];

            //zkopíruj nRowSwap radek do pomocneho pole tempArray
            for(int j=0;j<my2DArray.GetLength(1);j++)
            {
                my2DArray[0, j] = my2DArray[nRowSwap, j];
            }

            //Přepsání mRowswap radku pomocnym polem tempArray
            for (int j=0;j<my2DArray.GetLength(1);j++)
            {
                my2DArray[mRowSwap, j] = tempArray[j];
            }
            //vypsání do konzole
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(j); j++)
                {
                    Console.Write(my2DArray[i, j] + "");
                }
            }
            Console.Write("\n");

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            int[]tempArrayColumn = new int[5];

            //zkopirovani nColSwap sloupce do pomocneho pole tempArrayColumn
            for (int i = 0; i<my2DArray.GetLength(0);i++)
            {
                tempArrayColumn[i] = my2DArray[i, nColSwap];
            }

            //prepsani nColSwap sloupce sloupcem mColSwap
            for (int i = 0;i<my2DArray.GetLength(0);i++)
            {
                my2DArray[i, nColSwap] = my2DArray[i, mColSwap];
            }

            //prepsani mColSwap sloupce pomocnym polem tempArrayColumn
            for (int i=0;i<my2DArray.GetLength(0);i++)
            {
                my2DArray[i,mColSwap] = tempArrayColumn[i];
            }

            //vypsani do konzole
            for(int i=0;i<my2DArray.GetLength(0);i++)
            {
                for (int j=0;j<my2DArray.GetLength(j);j++)
                {
                    Console.Write(my2DArray[i, j] + "");
                }
            }
            Console.Write("\n");
            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i=0;i<=my2DArray.GetLength(0)/2;i++)
            {
                int temp = my2DArray[i, i];
                int reversedIndex = my2DArray.GetLength(0) - i;
                my2DArray[i, i] = my2DArray[reversedIndex, reversedIndex];
                my2DArray[reversedIndex, reversedIndex] = temp;
            }

            //vypsani do konzole
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(j); j++)
                {
                    Console.Write(my2DArray[i, j] + "");
                }
            }
                //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
                for (int i = 4; i >= 0; i--)
            {
                Console.Write(my2DArray[i, my2DArray.GetLength(0) - i - 1] +;
            }
                for (int i =4; i>=my2DArray.GetLength(0)/2;i--)
            {
                int temp = my2DArray.GetLength(0)-i-1
            }

            Console.ReadKey();
        }
    }
}
