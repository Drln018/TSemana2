using System;

namespace EJER1
{
    class Program
    {
        static void Main(string[] args)
        {
            char valor; 
            Console.WriteLine("Escriba un valor");
            valor = Convert.ToChar(Console.ReadLine());

            if (char.IsUpper(valor))
                Console.WriteLine("Es mayuscula");
            else
                Console.WriteLine("Es minuscula");
            Console.ReadKey();
        }
    }
}
