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
            int[] massiv = new int[20];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(-10, 20);
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < massiv.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < massiv.Length; j++)
                {
                    if (massiv[j] < massiv[min])
                    {
                        min = j;
                    }
                    if (min != i)
                    {
                        int temp = massiv[min];
                        massiv[min] = massiv[i];
                        massiv[i] = temp;
                    }
                }
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + " ");
            }
        }
    }
}
