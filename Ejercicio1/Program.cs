using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a sumar");
            int num1 = 0, num2 = 0;
            Calculadora calculadora = new Calculadora();
            while (true)
            {
                try
                {
                    Console.Write("Ingrese primer numero: ");
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error. Debe ingresar un numero entero");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("\nIngrese segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error. Debe ingresar un numero entero");
                }
            }
            int resultado = calculadora.Sumar(num1, num2);
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }


    }
}
