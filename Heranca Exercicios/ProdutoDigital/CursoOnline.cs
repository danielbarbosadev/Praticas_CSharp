namespace Heranca_Exercicios
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline()
        {
            
        }

        public CursoOnline(string nome, decimal preco, int CargaHoraria) : base (nome, preco)
        {
            this.CargaHoraria = CargaHoraria;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine
            ($"""
            === RESUMO EX-02 CURSO ONLINE ===
            Nome: {Nome}
            Preço: {Preco:C2}
            Carga Horaria: {CargaHoraria}
            """);

        }
    }
}