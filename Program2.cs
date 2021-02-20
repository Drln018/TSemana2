using System;

namespace EJER2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidad, descuento, total;
            Console.WriteLine("Ingrese total a pagar");
            cantidad = Convert.ToInt16(Console.ReadLine());
            descuento = cantidad * 0.2;
            total = cantidad - descuento;

            if (cantidad > 300)
            Console.WriteLine("Con el descuento paga " + total);

            else

            Console.WriteLine("El total a pagar es: " + cantidad);
            Console.ReadKey();          
        }
    }
}
