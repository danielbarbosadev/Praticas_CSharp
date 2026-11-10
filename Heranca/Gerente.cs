using System.Reflection.Metadata;

namespace Heranca
{
    public class Gerente : Funcionario
    {
        
        public int Codigo { get; set; }

        public Gerente()
        {

        }

        public Gerente(string nome, decimal salario) : base(nome, salario)
        {

        }

        public void GerenciarEquipe()
        {
            Console.WriteLine("O gestor está gerenciando a equipe");
        }

        public void ExibirSalario()
        {
            Console.WriteLine($"Salário: {Salario:F2}");
        }

        public void DefinirSalario(decimal valorSalario)
        {
            Salario = valorSalario;
        }

        public override decimal CalcularBonus()
        {
            return 1000m;
        }
    }
}