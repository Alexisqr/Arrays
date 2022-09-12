

using System;
using System.Collections;
using System.Text.RegularExpressions;


namespace MaxSequenceOfEqualElements
{
    internal class MaxSequenceOfEqualElements
    {
        public static void Fun(int[] Mas)
        {
            int[] Repeat = new int[Mas.Length];
            for (int i = 0; i < Repeat.Length; i++)
            {
                Repeat[i] = -1;
            }
            int[] end = new int[Repeat.Length];
            int Len_rep = 0;
            int c, k;

            k = 0;

            c = 0;
            int p = 0;
            int start = 0, len = 0;
            int start_p = 0, len_p = 0;

            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas.Length; j++)
                {

                    if (Mas[i] == Mas[j])
                    {
                        p++;

                        len_p++;

                        if (len_p == 2)
                        {
                            start_p = Mas[i];

                        }



                    }

                }
               
                if (len != 0 && len == len_p && Repeat[c] != Mas[i])
                {

                    k++;
                   
                    
                    Repeat[c] = Mas[i];
                    
                    c++;
                    
                    if (len > Len_rep&&k!=1)
                    {


                        Array.Clear(Repeat, 0, Repeat.Length);
                        k = 0;
                        c = 0;
                        Len_rep = 0;
                    }
                    else
                    {
                        
                        Len_rep = len_p;
                    }

                }
                if (len_p > len)
                {

                    len = len_p;

                    start = start_p;





                }




                len_p = 0;
            }

           
            for (int i = 0; i < k; i++)
            {
                for (int j = i ; j > 0; j--)
                {
                    if (Repeat[j - 1] > Repeat[j])
                    {
                        int temp = Repeat[j - 1];
                        Repeat[j - 1] = Repeat[j];
                        Repeat[j] = temp;
                    }
                }
            }
         
            int k2 = 0;
          
            for (int i = 0; i < k; i++)
            {
                if (i == 0)
                {

                    end[k2] = Repeat[i];
                    k2++;
                }
                else if (end[k2 - 1] != Repeat[i])
                {

                    end[k2] = Repeat[i];
                    k2++;
                }
               
            }
            
            if (k2>=2)
            {
                Console.Write("The numbers ");
                for (int i = 0; i < k2; i++)
                {

                    Console.Write(end[i]);
                    if (i == k2 - 2)
                    {
                        Console.Write(" and ");
                    }
                    else if (i != k2 - 1)
                    {
                        Console.Write(" , ");
                    }

                }
                Console.Write(" have the same maximal frequence (each occurs " + len + " times). The leftmost of them is " + start + ". ");
            }

            else
            {
                if (p != 0)
                {

                    Console.Write("The number " + start + " is the most frequent(occurs " + len + " times) ");


                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(" there is no...");
                }



            }

        }
        static void Main(string[] args)
        {
            string R1;

            Console.WriteLine("Enter array 1:");

            R1 = Console.ReadLine();
            string[] nom = R1.Split(' ');
            int[] Mas = new int[nom.Length];
            for (int i = 0; i < nom.Length; i++)
            {
                Mas[i] = Convert.ToInt32(nom[i]);
            }
            MaxSequenceOfEqualElements.Fun(Mas);
        }
    }
}
