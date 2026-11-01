/*
    Sistema saiba quem é o cliente, e o valor bruto, 

    regras de desconto
    Pedido igual ou maior que 100:
    - Frete 0
    - Desconto de 10% em cima do valor bruto

    Se não cumprir essa regra:
    - Frete 15R$
    - Desconto 0
*/

decimal descontoAplicado;
decimal frete;
string nomeCliente;
decimal valorLiquido;

Console.Write("Nome do cliente: ");
nomeCliente = Console.ReadLine()!;


Console.Write("Valor do pedido (Valor Bruto): ");
if (!decimal.TryParse(Console.ReadLine()!, out decimal valorBruto))
{
    Console.WriteLine("Valor inválido. Tente novamente!");
}
else
{
    if (valorBruto >= 100)
    {
        descontoAplicado = valorBruto * 0.1m;
        frete = 0m;
    }
    else
    {
        descontoAplicado = 0m;
        frete = 15m;
    }

    valorLiquido = valorBruto - descontoAplicado + frete;

    Console.WriteLine();

    Console.WriteLine
    ($""" 
    === RESUMO DO PEDIDO ===
    Cliente: {nomeCliente}
    Valor Bruto: {valorBruto:C2}
    Desconto Aplicado: {descontoAplicado:C2}
    Valor do frete: {frete:C2}
    -------------------------------------
    Valor Total a Pagar: {valorLiquido:C2}
    """);
}







