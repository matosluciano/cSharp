using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo While

            /*
             * int valor = 0;

            while (valor < 10)
            {
                Console.WriteLine("O valor é " + valor);

                valor++;*/

            #endregion

            #region Ciclo do-While
            /*
             int valor = 0;

            do
            {
                Console.WriteLine("O valor é: " + valor);
                valor++;
            } while (valor < 10);
            */
            #endregion

            #region Ciclo For
            /*
            for (
                int i = 0, j = 10;
                i < 10;
                i++, j--
                )
            {
                Console.WriteLine("I =" + i + " | J " + j);
            }
            */
            #endregion

            #region Ciclo Foreach

            string[] nomes = {"Luciano", "Mãe", "Pai", "Jane", "Allan"};
            // Abaixo usei a string para declarar iniciar a variável uma vez que já estava declarada como string, porém poderia 
            // ter usado um var no lugar do string que daria certo.
            foreach (string i in nomes)
            {
                Console.WriteLine("Nome: " + i);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
