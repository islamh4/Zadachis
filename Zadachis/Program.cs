using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Zadachis
{
    class Files
    {
        public static void File1(object thred)
        {
            bool digitOrLetter = false;
            string randomWord = "";
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                if (digitOrLetter)
                {
                    randomWord += (char)random.Next(65, 90);
                }
                else
                {
                    randomWord += (char)random.Next(48, 57);
                }
                digitOrLetter = !digitOrLetter;
            }
            for (int i = 1; i <= 10; i++)
            {
                File.WriteAllText(@"C:\Users\islam\Desktop\File\" + $"Файл {i}{thred as string}.txt", $"{thred as string}, рандом  сгенерированный текст: {randomWord}", Encoding.UTF8);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Files.File1));
            Thread thread1 = new Thread(new ParameterizedThreadStart(Files.File1));
            thread.Start("Thread 1");
            thread1.Start("Thread 2");
        }
    }
}
