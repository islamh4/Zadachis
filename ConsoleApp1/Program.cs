using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Zadachis
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] asd = new int[5, 5];
            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for (int j = 0; j < asd.GetLength(1); j++)
                {
                    asd[i, j] = random.Next(0, 9);
                    Console.Write(asd[i,j]+" ");
                }
                Console.WriteLine();
            }
            for (int l = 0; l < asd.GetLength(0); l++)
            {
                for (int i = 0; i < asd.GetLength(1)-1; i++)
                {
                    int min = i;
                    for (int j = i+1; j < asd.GetLength(1); j++)
                    {
                        if (asd[l, j] < asd[l,min])
                        {
                            min = j;
                        }
                        if (min != i)
                        {
                            int temp = asd[l, min];
                            asd[l, min] = asd[l, i];
                            asd[l, i] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for (int j = 0; j < asd.GetLength(1); j++)
                {
                    Console.Write(asd[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}