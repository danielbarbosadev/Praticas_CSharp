using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Exercicios
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal()
        {
            
        }

        public RetiradaLocal(int distancia) : base (distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return Distancia * 0;
        }
    }
}