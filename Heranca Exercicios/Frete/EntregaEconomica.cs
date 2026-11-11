namespace Heranca_Exercicios
{
    public class EntregaEconomica : Entrega
    {

        public EntregaEconomica()
        {
            
        }

        public EntregaEconomica(int distancia) : base (distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return Distancia * 0.2m;
        }
    }
}