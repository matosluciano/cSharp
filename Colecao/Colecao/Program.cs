using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vetores
            /*
            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            numeros[2] = 55;

            //string[] nomes = new string[5];

            //nomes[0] = "Luciano";
            //nomes[1]= "Maria";
            //nomes[2] = "José";
            //nomes[3] = "Jane";
            //nomes[4] = "Allan";

            string[] nomes = {

                "Luciano", "Maria", "José", "Jane", "Allan"
            };

            nomes[2] = "Matos";

            Console.WriteLine(numeros[2]);
            Console.WriteLine(nomes[2]);
            */
            #endregion

            #region Vetor Bidimensional ou Matriz
            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;


            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");

            Console.WriteLine();

            string[,] nomes =
            {
                {"Luciano", "José", "Maria" },
                {"Jane", "Allan", "Matos" }
            };

            #endregion


            Console.WriteLine(nomes[0, 0]);

            Console.ReadKey();
        }
    }
}

