using System;


namespace Compare_Char_Arrays
{
    internal class CompareCharArrays
    {
        public static void Fun(char[] arr1, char[] arr2)
        {
            Console.WriteLine(" ");
            if (arr1.Length <= arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (Convert.ToInt32(arr1[i]) < Convert.ToInt32(arr2[i]))
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);
                           
                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        Console.WriteLine(" ");
                        break;
                    }else if (Convert.ToInt32(arr2[i]) < Convert.ToInt32(arr1[i]))
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                           
                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);
                        }
                        Console.WriteLine(" ");
                        break;

                    }
                    if(i== arr1.Length - 1)
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);
                            

                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        Console.WriteLine(" ");
                    }

                }
            }
            else if(arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (Convert.ToInt32(arr1[i]) < Convert.ToInt32(arr2[i]))
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);

                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        Console.WriteLine(" ");
                        break;
                    }
                    else if (Convert.ToInt32(arr2[i]) < Convert.ToInt32(arr1[i]))
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);

                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);
                        }
                        Console.WriteLine(" ");
                        break;

                    }
                    if (i == arr2.Length - 1)
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            Console.Write(arr2[j]);
                        }
                        Console.WriteLine(" ");
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            Console.Write(arr1[j]);


                        }
                        Console.WriteLine(" ");
                    }
                   
                        

                }
            }
           

        }

        static void Main(string[] args)
        {
            string R1;
            string R2;
            Console.WriteLine("Enter the first word");

            R1 = Console.ReadLine();

            Console.WriteLine("Enter the second word");

            R2 = Console.ReadLine();
            R1 = R1.Replace(" ", string.Empty);
            R2 = R2.Replace(" ", string.Empty);
            char[] arr1 = R1.ToCharArray();
            char[] arr2 = R2.ToCharArray();
            CompareCharArrays.Fun(arr1,arr2);


            

        }
    }
}
