namespace Entendendo_POO
{
    public  class Conta
    {
        public decimal saldo = 0;

        public void Depositar(decimal valor)
        {
            saldo += valor; 
            Console.WriteLine($"Saldo atualizado {saldo}");
        }
    }
}