namespace Heranca_Exercicios
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa()
        {
            
        }

        public EntregaExpressa(int distancia) : base (distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return Distancia * 0.5m;
        }
    }
}