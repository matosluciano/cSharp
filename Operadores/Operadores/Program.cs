using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores de Incremento e Decremento
            /*
           // Incrementa +1 ou decrementa -1
           int num1 = 10;

           //num1++;
           //++num1;
           //num1--;
           //--num1;


           Console.WriteLine(num1--);
           Console.WriteLine(num1++);
           Console.WriteLine(--num1);
           Console.WriteLine(--num1);
           */
            #endregion

            #region Operadores de Concatenação
            // O uso do "+" pode ser usado para unir duas strings.
            /* string nome = "Luciano ";
            string sobrenome = "Matos";
            String nomeCompleto = nome + sobrenome;
            */
            #endregion

            #region Operadores de Atribuição
            /*
            //int num1 = 10;

            //num1 += 20; // mesmo que num1 = num1 + 20;
            //num1 -= 2; // mesmo que num1 = num1 - 2;
            //num1 *= 20; // mesmo que num1 = num1 * 2;
            //num1 /= 4; // mesmo que num1 = num1 / 4;
            //num1 %= 2; // mesmo que num1 = num / 2; Resto da divisão igual a 0.
             

            // Aqui += pode servir como operador de concatenação se for uma string.
            string nome = "Luciano ";
            nome += "Matos";
            */
            #endregion

            #region Operadores de Igualdade / Comparação
            // Operador Booleano, retorna um resultado True ou False.
            /*
            bool res1 = 100 == (50 * 2);
            bool res2 = (200 / 2) != (100 + 100);
            */
            #endregion

            #region Operadores Relacionais
            // bool res = 100 < 50 ; 
            #endregion

            #region  Operadores Lógicos
            /*
            // Operador && == And 
            // Operador ||  == Or
            // Operador && só retornará True se as duas expressões forem verdadeiras enquanto || só retornará verdadeiro se uma das expressões forem verdadeiras.
            bool res1 = 100 > 50;
            bool res2 = 50 != 50;


            bool final1 = res1 && res2;
            bool final2 = res1 || res2;       
            */
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
