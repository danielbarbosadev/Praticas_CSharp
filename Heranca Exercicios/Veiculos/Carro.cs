namespace Heranca_Exercicios
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine
            ($"""
            === RESUMO EX-01 CARRO ===
            Marca: {Marca}
            Modelo:{Modelo}
            Quantidadade de Portas: {QuantidadePortas}
            """);  
            
        }
    }
}