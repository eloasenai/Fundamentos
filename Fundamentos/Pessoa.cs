﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Envelhecer(int anos)
        {
            this.Idade += anos;
            Console.WriteLine(this.Nome + ",Sua idade agora é" + this.Idade);
        }
        public void ApresentarSe()
        { 

        Console.WriteLine("Olá, meu nome é" + this.Nome + ", tenho " + this.Idade + "sou " + this.Cargo + " e meu salario é R$ " + this.Salario); 
        }
    }
}
   