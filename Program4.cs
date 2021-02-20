using System;

namespace EJER4
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Ingrese año ");
            año = Convert.ToInt32(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año no es bisiesto");
            Console.ReadKey();




        }
    }
}
