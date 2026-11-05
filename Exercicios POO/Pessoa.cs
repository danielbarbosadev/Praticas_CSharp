using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string Idade { get; private set; }
        public string Cidade { get; private set; }

        public void Apresentar()
        {
            Console.WriteLine
            ($""" 
            === RESUMO INFORMAÇÕES ===
            Nome do usuário: {Nome}
            Idade: {Idade}
            Cidade: {Cidade}
            """);
        }
    }
}