using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            #region Métodos simples
            //m.Cumprimentar();
            #endregion

            #region métodos com parâmetros
            /*
            m.Somar(50, 60);
            m.Apresentar("Luciano", 37);
            */
            #endregion

            #region Passagem de parâmetros por valor e por referência
            /*
            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
            */
            #endregion

            #region Métodos com retorno de valores
            /*
            string nomeCompleto = m.MontaNome("Luciano", "Matos");
            int codigoChar = m.CodigoChar('a');
            double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);
            */
            #endregion

            m.Cumprimentar();
            m.Cumprimentar("Luciano");
            m.Cumprimentar("Luciano", 18);

            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("Luciano", "luciano");

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }
}
