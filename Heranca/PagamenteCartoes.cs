namespace Heranca
{
    public class PagamenteCartoes : IPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento via cartão: {valor:c2}");
        }

        public void Receber(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}