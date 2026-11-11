namespace Heranca_Exercicios
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadadePaginas { get; set; }

        public Ebook()
        {
            
        }

        public Ebook(string nome, decimal preco, int QuantidadadePaginas) : base (nome, preco)
        {
            this.QuantidadadePaginas = QuantidadadePaginas;
        }

        public override void ExibirInformacoes()
        {
           Console.WriteLine
            ($"""
            === RESUMO EX-02 EBOOK ===
            Nome: {Nome}
            Preço:{Preco:C2}
            Quantidade de Páginas: {QuantidadadePaginas}
            """);

        }
    }
}