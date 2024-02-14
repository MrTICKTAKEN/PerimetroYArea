using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroYArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué quieres calcular?");
            Console.WriteLine("1. El Área");
            Console.WriteLine("2. El Perímetro");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                CalcularArea();
            }
            else if (opcion == 2)
            {
                CalcularPerimetro();
            }
            else
            {
                Console.WriteLine("Opción no aceptada.");
            }
        }

        static void CalcularArea()
        {
            Console.WriteLine("Ingresa el número de lados del polígono:");
            int numLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la longitud de un lado del polígono:");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            double apotema = CalcularApotema(numLados, longitudLado);

            double area = (numLados * longitudLado * apotema) / 2;
            Console.WriteLine($"El área del polígono es: {area}");
        }

        static void CalcularPerimetro()
        {
            Console.WriteLine("Ingresa el número de lados del polígono:");
            int numLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la longitud de un lado del polígono:");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            double perimetro = numLados * longitudLado;
            Console.WriteLine($"El perímetro del polígono es: {perimetro}");
        }

        static double CalcularApotema(int numLados, double longitudLado)
        {
            double apotema;
            if (numLados % 2 == 0)
            {
                apotema = longitudLado / (2 * Math.Tan(Math.PI / numLados));
            }
            else
            {
                apotema = longitudLado / (2 * Math.Sin(Math.PI / numLados));
            }
            return apotema;
        }
    }
}
