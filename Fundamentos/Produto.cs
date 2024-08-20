using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Produto
    {
        //Atributos
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Estoque { get; set; }

        //Metodos
        public void QuantidadeEstoque()
        {
            Console.WriteLine("A quantidade em estoque é: " + this.Estoque);

        }
    }
}
