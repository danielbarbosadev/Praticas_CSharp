using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Cidade { get; private set; }


        public Pessoa()
        {
            Nome = "Nome não informado";
            Idade = 0;
            Cidade = "Cidade não informada";
        }

        public Pessoa(string nome, int idade, string cidade)
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
        }

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