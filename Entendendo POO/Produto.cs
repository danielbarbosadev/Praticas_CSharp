namespace Entendendo_POO
{
    public class Produto 
    {
        public string? Nome {get; set;}

        public decimal Preco { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - {Preco:c2}");
        }
    }
}