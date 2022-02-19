using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPRATURAS ###");
            Console.Write("Insira a tempratura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            // (c * 9 / 5) + 32 = F
            f = (c * 9 / 5) + 32;

            // c + 273,15
            k = c + 273.15;

            Console.WriteLine(c + " graus celsius = " + f + " graus fahreinheit. ");
            Console.WriteLine(c + " graus celsius = " + k + " graus kelvin. ");
            Console.WriteLine("--------------------------------");
            Console.ReadKey();


        }
    }
}
