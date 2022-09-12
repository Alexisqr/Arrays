using System;

namespace SieveOfEratosthenes
{
    internal class SieveOfEratosthenes
    {


        public static void Fun(int n)
        {
            bool[] Mas = new bool[n];
            for (int i = 0; i < n; i++)
            {
                Mas[i] = true;
            }
            Mas[0] = false;
            Mas[1] = false;
            for (int i = 2; i < n; i++) {
                for (int j = i * i;j<n;j=j+i)
                {
                    Mas[j] = false;
                }

            }
            Console.WriteLine(" ");
            for (int j = 0; j < Mas.Length; j++)
            {
                if (Mas[j])
                {

                    Console.Write(j);
                    Console.Write(" ");
                }



            }
            Console.WriteLine(" ");

        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("n =");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            SieveOfEratosthenes.Fun(n);
        }
    }
}
