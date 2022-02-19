using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        #region Enum (Enumerações)
        /*enum Notas
        {
            Minimo = 10,
            Media = 20,
            Maxima = 30
            
        }
        */
        #endregion

        #region Struct (Estruturas)
        // Definem a estrutura do código conforme a declaração inicial.
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region Numericas Integrais
            /*
             // Integral assinado
             /*sbyte num1 = 10;
             short num2 = 20;
             int num3 = 30;
             long num4 = 40L;

             // Integral sem sinal
             byte num5 = 10;
             ushort num6 = 20;
             uint num7 = 30;
             ulong num8 = 40;

             sbyte numero;
             numero = 100;
             numero = 120;
             numero = num1;
             */
            #endregion

            #region Caractere
            /*
             // Ao usar o tipo char, o caractere \u indica que virá a seguir um código.
             char letra = '\u0061';

             // \n usado para quebrar a linha.
             char escape = '\\';

             // Caractere literal.
             char literal = 'C';
            */
            #endregion

            #region String (Cadeia de caracteres)
            /*
            // Variáveis do tipo String.
            string texto = "Luciano\n1984 @@$$??";
            string mensagem = null;
            mensagem = texto;
            */
            #endregion

            #region Tipo implícito Var
            /*
            // Tipo Var o programa se encarrega de determinar o tipo de dado, porém só poderá ser modificado se for pelo mesmo tipo.
            var valor = 140;
            valor = 100;
            valor = "Luciano" // Não será aceito, por ser do tipo String.
            */
            #endregion

            #region Object (Base para todos os tipos de dados)
            /*
            // É a base de todos os tipos para o C#, pode ser atribuído qualquer valor modificado para outro tipo de dados posteriormente, porém
            // não pode ser usado em uma estrutura condicional ou em operações matemáticas.
            object obj = 200;
            obj = "Luciano";
            obj = false;
            obj = 5.5;
            */
            #endregion

            #region Constantes
            /*
            // Exemplo o número pi que nunca muda, é uma constante.
            const double pi = 3.14;
            const String nome = "Luciano";
            pi = 17; // Implicará em erro, porque o valor foi declarado como uma constante.
            */
            #endregion

            #region Continuação Enum (Enumerações)
            /*
             * // Atribui um valor automaticamente ou pré definido.
            Notas notaAlunos = Notas.Maxima;
            */
            #endregion

            #region Continuação Struct (Estruturas)
            /*
            Pessoa p1 = new Pessoa();
            p1.altura = 1.71;
            p1.idade = 37;
            p1.nome = "Luciano";

            Pessoa p2 = new Pessoa()
            {
                nome = "José",
                idade = 67,
                altura = 1.65
            };

            p1.nome = "Maria";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.altura);
            Console.WriteLine(p1.idade);

            Console.WriteLine();


            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.altura);
            Console.WriteLine(p2.idade);
            */
            #endregion

            Console.ReadKey();
        }
    }
}
