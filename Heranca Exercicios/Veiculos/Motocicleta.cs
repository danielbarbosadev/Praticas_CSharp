namespace Heranca_Exercicios 
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }


        public override void ExibirInformacoes()
        {
            Console.WriteLine
            ($"""
            === RESUMO EX-01 MOTOCICLETA ===
            Marca: {Marca}
            Modelo:{Modelo}
            Cilindradas: {Cilindradas}
            """);
             
        }
    }


}