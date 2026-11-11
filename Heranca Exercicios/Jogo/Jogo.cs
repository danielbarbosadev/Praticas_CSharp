namespace Heranca_Exercicios
{
    public abstract class Jogo
    {
        protected string? Nome { get; set; }
        protected string? Plataforma { get; set; }


        public Jogo()
        {
            
        }

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public abstract void ExibirInformacoes();
        
    }
}