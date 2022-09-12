using System;


namespace MaxSequenceOfEqualElements
{
    internal class MaxSequenceOfEqualElements
    {
        public static void Fun(int[] Mas)
        {
            int p = 0;
            int start = 0, len = 1;
            int start_p = 0, len_p = 1;
            for (int i = 0; i < Mas.Length; i++)
            {
            
                if (i != Mas.Length - 1)
                {
                    
                    if (Mas[i] == Mas[i + 1])
                    {
                        p++;

                        len_p++;
                        if (len_p == 2)
                        {
                            start_p = i;
                           
                        }

                    }
                    else
                    {

                        if (len_p > len)
                        {
                           
                            start = start_p;
                           
                            len = len_p;
                        }
                        len_p = 1;
                    }
                }else if(Mas[i-1] == Mas[i]&&i!=0)
                {
                   

                   
                    if (len_p == 2)
                    {
                        start_p = i;

                    }
                    if (len_p > len)
                    {

                        start = start_p;

                        len = len_p;
                    }

                }
                

               
            

            }
           
            Console.WriteLine(" ");
            if(p!= 0)
            {
                for (int l = start; l < start + len; l++)
                {
                    Console.Write(Mas[l] + " ");

                }
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" there is no...");
            }
            
           
            
        }
        static void Main(string[] args)
        {
            string R1;

            Console.WriteLine("Enter array :");

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
