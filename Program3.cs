using System;

namespace EJER3
{
    class Program
    {
        static void Main(string[] args)
        {
            double preciohora=16, horastrabajadas, horasextra, salario, sueldoextra;

            Console.WriteLine("Ingrese horas trabajadas: ");
            horastrabajadas = double.Parse(Console.ReadLine());

            if (horastrabajadas <= 40 && horastrabajadas >= 0)
            {
                salario = horastrabajadas * preciohora ;
                Console.WriteLine("El salario es: " + salario);
            }
            else if (horastrabajadas > 40)
            {
                salario = 640;
                horasextra = (horastrabajadas - 40);
                sueldoextra = salario + (horasextra * 20);
                Console.WriteLine("Horas extras: " + horasextra);
                Console.WriteLine("El salario es: " + sueldoextra);
            }
            else
                Console.WriteLine("las horas trabajadas no pueden ser negativas");
            Console.ReadLine();


        }
    }
}
