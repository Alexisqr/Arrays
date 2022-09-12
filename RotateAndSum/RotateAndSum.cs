using System;
using System.Collections.Generic;

namespace RotateAndSum
{
    internal class RotateAndSum
    {
        public static void Sum(int[] Incoming_data, int[] Sum)
        {
            for (int h = 0; h < Sum.Length; h++)
            {
                Sum[h] = Sum[h] + Incoming_data[h];
            }
        }
            public static void Function(int [] Incoming_data)
        {
            int y = 0;
            int[] temporary = new int[Incoming_data.Length];
            for (int j = 0; j < Incoming_data.Length; j++)
                {

                    if (j == 0)
                    {
                        temporary[j] = Incoming_data[Incoming_data.Length - 1];
                    }
                    else
                    {
                       
                        temporary[j] = Incoming_data[y];
                        y = y + 1;
                    }
                  
                }
            for (int i = 0; i < Incoming_data.Length; i++)
            {
                Incoming_data[i] = temporary[i];
            }

        }
        static void Main(string[] args)
        {
            int k;
            string R1;
           
            Console.WriteLine("Enter array :");

            R1 = Console.ReadLine();
            string[] nom = R1.Split(' ');
            int[] Mas =new int [nom.Length];
            for(int i = 0; i < nom.Length; i++)
            {
                Mas[i] = Convert.ToInt32(nom[i]);
            }
            int[] Sum = new int[Mas.Length];
            Console.WriteLine(" k = ");
            k = int.Parse(Console.ReadLine());
            for(int i = 0; i < k; i++)
            {
                
                RotateAndSum.Function(Mas);
                
                RotateAndSum.Sum(Mas,Sum);
               
               
            }
            Console.WriteLine("Sum =");
            Console.WriteLine(" ");
            for (int j = 0; j < Sum.Length; j++)
            {
                Console.Write(Sum[j]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
        }
    }
}
