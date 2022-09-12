using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    internal class PairsByDifference
    {

        static void Fun(int[] Mas,int k)
        {
            Array.Sort(Mas);
            int l=0, s = 0,u =0;
            int[] End = new int[Mas.Length* Mas.Length];
            int[] New = new int[Mas.Length];
            for (int i = 0; i < New.Length; i++)
            {
                if(i != New.Length - 1)
                {
                    if (Mas[i] != Mas[i + 1])
                    {
                        New[s] = Mas[i];

                        s++;
                    }
                }
                else
                {
                    if (Mas[i-1] != Mas[i])
                    {
                        New[s] = Mas[i];

                        s++;
                    }
                }
            
            }
         
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s ; j++)
                {
                    if (New[i] - New[j] == k && New[i] > New[j])
                    {
                        End[u] = New[i];
                        
                        u++;
                        End[u] = New[j];
                        
                        u++;
                        l++;
                       

                    }
                }
            }
            if (l > 0)
            {
                Console.WriteLine(l);
                Console.WriteLine(" ");
                Console.Write("Pairs of elements with difference " + l + " -> ");

                for (int i = 0; i < u; i++)
                {
                    Console.Write("{ " + End[i] + ", ");
                    i++;
                    Console.Write(End[i] + " } ");
                    if (i != u - 1)
                    {
                        Console.Write(" , ");
                    }

                }
                Console.WriteLine(" ");

            }
            else
            {
                Console.WriteLine(0);
                Console.WriteLine(" No pairs with difference " + k);
            }

        }
        
        static void Main(string[] args)
        {
            string R1;
            int k;

            Console.WriteLine("Enter array :");

            R1 = Console.ReadLine();
            string[] nom = R1.Split(' ');
            int[] Mas = new int[nom.Length];
            for (int i = 0; i < nom.Length; i++)
            {
                Mas[i] = Convert.ToInt32(nom[i]);
            }
            Console.Write("n = ");
            k = Convert.ToInt32 (Console.ReadLine());
            PairsByDifference.Fun(Mas,k);
        }
    }
}
