using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            /*
            MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse m2 = null;

            OutraClasse outra = new OutraClasse();
            OutraClasse outra2 = outra;
            */
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Luciano";
            p1.sobrenome = "de Oliveira Matos";
            p1.anoNascimento = 1984;

            Pessoa p2 = new Pessoa()
            {
                nome = "Osmarina",
                sobrenome = "de Oliveira",
                anoNascimento = 1949               
            };

            p1.nome = "Luciano";

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);

            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);

            p2.Cumprimentar();

            Console.ReadKey();

        }
    }
    class MinhaClasse
    {
       
    }
}
