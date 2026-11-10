namespace Heranca
{
    public interface IPagamento //* Uma interface define "um contrato" que estabelece quais métodos, propriedades ou outros membros uma classe deve disponibilizar
    {
        void Pagar(Decimal valor);

        void Receber(Decimal valor);


    }
}