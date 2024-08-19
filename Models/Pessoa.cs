using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; } // método
        public int Idade { get; set; }// método

        public void Apresentar()// método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} " +
            $" e tenho {Idade} anos");
            //Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos"); //diferente formar de quebrar linha.
        }
    }

}
