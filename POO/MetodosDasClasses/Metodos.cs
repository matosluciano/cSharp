﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Metodos
    {
        // Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo !");
        }

        // Métodos com parâmetros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Olá, meu nome é " + nome + " e tenho " + idade + " anos.");
        }

        // Passagem com parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por valor) é: " + valor);
        }
        // Passagem de parâmetros com referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por referência) é: " + valor);
        }
    }
}
