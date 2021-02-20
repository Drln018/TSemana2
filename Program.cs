using System;

namespace EJER6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 0, num;
                Console.WriteLine("NUMERO");
                num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < (num + 1); i++)
                {
                    if (num % i == 0)
                    {
                        a++;
                    }
                }
                if (a != 2)
                {
                    Console.WriteLine(num + " No es primo");
                }
                else
                {
                    Console.WriteLine(num + " Si es primo");
                }
                Console.ReadLine();

            }
        }
    }
}
