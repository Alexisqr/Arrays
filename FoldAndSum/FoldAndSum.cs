using System;


namespace FoldAndSum
{
    internal class FoldAndSum
    {
        public static void Sum(int[] Incoming_data, int[] Sum)
        {
            for (int h = 0; h < Sum.Length; h++)
            {
               Sum[h] = Sum[h] + Incoming_data[h];
            }
        }
        public static void Function(int[] Incoming_data, int[] K1, int[] K2)
        {
            int b = -1;
            int c = 0;
            int a = -1;
            int k = (Incoming_data.Length / 4);
            int[] temporary = new int[k];
           
            for (int i = Incoming_data.Length-1; i >= 0; i--)
            {
              if(i<k)
                {
                    b++;
                    K1[b] = Incoming_data[i];
                   
                }else if(i > Incoming_data.Length - k - 1)
                {
                    a++;
                    temporary[a] = Incoming_data[i];
                    
                }
                else
                {
                    K2[c]= Incoming_data[i];
                    c++;
                }
                  
               
            }
            Array.Reverse(K2);
            c = 0;
            for (int i = k; i < K1.Length; i++)
            {
                K1[i] = temporary[c];
                c++;
            }
            for (int j = 0; j < K1.Length; j++)
            {
                
            }
            for (int j = 0; j < K2.Length; j++)
            {
                
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
            int[] K1 = new int[Mas.Length / 2];
            int[] K2 = new int[Mas.Length / 2];
            int[] Sum = new int[K1.Length];
            //int[] Sum = new int[Mas.Length];

            
                FoldAndSum.Function(Mas,K1,K2);
               
            FoldAndSum.Sum(K1, Sum);
            FoldAndSum.Sum(K2, Sum);
            Console.WriteLine("Sum =");
           
            for (int j = 0; j < Sum.Length; j++)
            {
                Console.Write(Sum[j]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");

        }
    }
}
