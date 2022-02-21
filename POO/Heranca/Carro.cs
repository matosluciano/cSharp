﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int VelocidadeMaxima { get; set; }
        
        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor. ");
        }

        
        public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }
        public void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
