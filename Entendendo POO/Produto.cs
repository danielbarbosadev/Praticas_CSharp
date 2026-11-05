namespace Entendendo_POO
{
    public class Produto 
    {
        public string? Nome {get; private set;}

        public decimal Preco { get; private set; }

        public Produto()
        {
            
        }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - {Preco:c2}");
        }

        public void AlterarNome(string novoNome)
        {
            if (novoNome == null || novoNome == "")
            {
                Console.WriteLine("[ERRO] Nome inválido para produto");
            }

            Nome = novoNome;
        }

        public void AlterarPreco(decimal novoPreco)
        {
            if (novoPreco <= 0)
            {
                Console.WriteLine("[ERRO] Valor não permitido");
                return;
            }

            Preco = novoPreco;
        }
    }
}