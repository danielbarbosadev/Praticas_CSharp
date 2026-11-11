namespace Heranca_Exercicios
{
    public abstract class ProdutoDigital
    {
        protected string? Nome { get; set; }

        protected decimal Preco { get; private set; }
        
        public ProdutoDigital()
        {
            
        }

        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public abstract void ExibirInformacoes();
    }
}