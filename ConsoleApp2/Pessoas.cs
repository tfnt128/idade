using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Pessoas
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoas(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return "Pessoa mais velha: " + Nome;
        }
    }
}
