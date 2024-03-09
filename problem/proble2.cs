using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al calculador de descuentos!");

            double totalSinDescuento = 0;
            double totalConDescuento = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Ingresa el precio del producto {i}: ");
                double precio = Convert.ToDouble(Console.ReadLine());

                if (precio > 100)
                {
                    // Aplicar 15% de descuento
                    double descuento = precio * 0.15;
                    totalConDescuento += precio - descuento;
                }
                else
                {
                    totalConDescuento += precio;
                }

                totalSinDescuento += precio;
            }

            double ahorro = totalSinDescuento - totalConDescuento;
            Console.WriteLine("Total de compra sin descuento:"+ totalSinDescuento);
            Console.WriteLine("Total de compra con descuento"+ totalConDescuento);
            Console.WriteLine("Ahorro total:" + ahorro);
            Console.Read();
        }
        
    }
}




