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
            int sd = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            if (sd == f)
            {
                Console.WriteLine("number 1 = number 2");
            } else
            if (sd>f)
            {
                Console.WriteLine("number 1 > number2");
            }
            else
            {

            }
        }
    }
}