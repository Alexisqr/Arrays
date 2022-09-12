using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    internal class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string R1;
            char[] abc = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Console.WriteLine("Enter the  word");

            R1 = Console.ReadLine();

            char[] arr1 = R1.ToCharArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (arr1[i] == abc[j])
                    {
                        Console.WriteLine(arr1[i] + " -> " + j);
                    }
                }
            }
        }
    }
}
