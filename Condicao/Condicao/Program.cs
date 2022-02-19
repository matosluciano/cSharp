using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição Simples

            /*int valor = 5;

            if (valor > 5)
            {
                Console.WriteLine("Condição verdadeira");
            }
            else
            {
                Console.WriteLine("Condição retornou falso");
            }
            */
            #endregion

            #region Condição Encadeada
            /* int valor = 8;


            if (valor < 5)
            {
                Console.WriteLine("Condição verdadeira");
            }
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condição altenativa 1");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Con~dição altenativa 2");
            }
            else
            {
                Console.WriteLine("Con~dição altenativa final");
            }*/
            #endregion

            #region Condições Alinhadas
            // Estrutura alinhada é quando posso colocar uma condição dentro de outra condição.
            /*
             * int numero = 11;

            if (numero > 5)
            {
                Console.Write("O número é maior que 5 ");

                if (numero % 2 == 0)
                {
                    Console.Write("e é par!");
                }
                else
                {
                    Console.Write("e é impar!");
                }
            }
            */
            #endregion

            #region Operador Ternário

            int numero = 10;
            //string mensagem = numero > 5 ? "Maior que 5." : "Menor que 5.";

            // Operador ternário: condição ? verificar se é True e : verificar se é False.

            //mensagem = numero > 5 ? "Maior que 5." : "menor que 5.";

            /*
            if (numero > 5)
            {
                mensagem = "O número é maior que 5.";
            }
            else
            {
                mensagem = "O número não é maior que 5.";
            }
            Console.WriteLine(mensagem);
            */
            #endregion

            Console.WriteLine(numero > 5 ? "Maior que 5." : "Menor que 5.");
            Console.ReadKey();
            
        }
    }
}
