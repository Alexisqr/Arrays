using System;
using System.Collections.Generic;

namespace _1.Largest_Common_End
{
    internal class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string R1;
            string R2;
            int h;
            h = 0;
            int b;
            b = 0;
            int b2;
            b2 = 0;
            Console.WriteLine("Enter array 1:");
         
            R1 = Console.ReadLine();
            
            string[] words1 = R1.Split(' ');

            Console.WriteLine("Enter array 2:");

            R2 = Console.ReadLine();
            int n;
            n = 0;
            string[] words2 = R2.Split(' ');
            if(words1.Length> words2.Length)
            {
                n = 1;
            }
            int f;
            f = 0;
            b = words1.Length - 1;
            b2 = words2.Length - 1;

            if (words1[0] == words2[0])
            {
                if (n == 1)
                {

                    for (int i = 0; i < words2.Length; i++)
                    {
                        if(words1[i] == words2[i])
                        {
                            f++;

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < words1.Length; i++)
                    {
                        if (words1[i] == words2[i])
                        {
                            f++;

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("The largest common end is at the left:");
                for (int i = 0; i < f; i++)
                {
                    Console.WriteLine(words1[i]);
                }
            }else if(words1[words1.Length-1] == words2[words2.Length - 1])
            {
                if (n == 1)
                {

                    for (int i = words2.Length-1; i>=0; i--)
                    {
                      

                        if (words1[b] == words2[i])
                        {
                            f++;
                            b--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = words1.Length - 1; i >= 0; i--)
                    {
                        
                        if (words1[i] == words2[b2])
                        {
                            f++;
                            b--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("The largest common end is at the right:");
      
                for (int i = words2.Length - 1; h < f; i--)
                {
                    h++;
                  
                    Console.WriteLine(words2[i]);
                }
            }
            else
            {
                Console.WriteLine("No common words at the left and right");
            }






        }
    }
}
