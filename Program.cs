using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение не используя знаки препинания");
            Console.WriteLine();

            string S1 = Console.ReadLine();
            string [] string1 = S1.Split();
            string resultmax = string.Empty;

            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i].Length > resultmax.Length)
                    resultmax = string1[i];
               
            }
           
         
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово = {0}", resultmax.Substring(0, 1).ToUpper() + resultmax.Substring(1));
            Console.ReadKey();
        }

    }
}
