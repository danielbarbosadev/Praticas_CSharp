using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Funcionario
    {
        public string? nome { get; set; }
        public string? cargo { get; set; }
        public decimal salario { get; private set; }  
        
        public Funcionario(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public void AumentarSalario(decimal porcentagem)
        {
            salario += salario * (porcentagem / 100);
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário líquido: {salario:c2}");
        }
    }
}