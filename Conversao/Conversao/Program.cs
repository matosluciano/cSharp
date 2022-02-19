using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Conversão Implícita
            /*
             * // Conversão implícita: a variável pode receber o valor de uma variável do mesmo tipo desde que seja comportada pelo tamanho.
            byte num1 = 100; // 8 bits, de 0 a 255
            ushort num2 = num1; // 16 bits, de 0 a 65.535

            float num3 = 1250.45f;
            double num4 = num3;

            num3 = num1;
            num2 = num1;

            // Vai receber o valor do código do caracterer "C"
            int numero = 'C';
            */
            #endregion

            #region Conversão Explícita
            /*
            // Pode-se fazer a conversão para um tipo de dado que não suporta o tamanho de outro tipo, mas e necessário explicitar que tipo de dados no qual 
            // se deseja fazer a conversão. Exemplo abaixo:  ushort num1 = 100;
                                                          // byte num2 = (byte)num1;

            ushort num1 = 100;
            byte num2 = (byte)num1;

            float num3 = 2500;

            // O tipo int não suporte o tipo float, por exemplo, mesmo fazendo a conversão se eu colocar um número inteiro na variável, se colocar um número real, será impresso na tela
            // os números da primeira casa decimal.
            int num4 = (int)num3;

            // Vai implrimir apenas o código da letra mas não a letra em si.
            char letra = (char)97;
            */

            #endregion

            #region Método Parse
            /*
            // Permite fazer a conversao de String para outro tipo de dado e ao fazer a conversão, a variável pode ser usada para realizar operações matemáticas.
            string txtnumero = "1985";
            int numero = int.Parse(txtnumero);

            byte num1 = byte.Parse("120");

            double num2 = double.Parse("125623,57");
            float num3 = float.Parse("427,25");
            */
            #endregion

            #region Classe Convert
            /*
            // Semelhante ao métido Parse mas deve ser usado já na declaração da variável.
            string texto = Convert.ToString(2500);
            double num1 = Convert.ToDouble(false);
            int num2 = Convert.ToInt32('C');
            */
            #endregion

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
