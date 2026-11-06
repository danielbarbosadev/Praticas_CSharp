using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO
{
    public class Veiculo
    {
        public decimal velocidade { get; private set;}

        public void alterarVelocidade(decimal novaVelocidade)
        {
            if(novaVelocidade < 0 || novaVelocidade > 200)
            {
                Console.WriteLine($"Velocidade inválida, Velocidade Atual: {velocidade}");
                return;
            }

            velocidade = novaVelocidade;

            Console.WriteLine($"Velocidade: {velocidade}");
        }
    }
}