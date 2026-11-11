namespace Heranca_Exercicios
{
    public abstract class Entrega
    {
        public int Distancia { get; set; }

        public Entrega()
        {
            
        }

        public Entrega(int distancia)
        {
            Distancia = distancia;
        }
        
        public abstract decimal CalcularFrete();
    }
}