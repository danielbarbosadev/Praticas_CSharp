using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Exercicios
{
    public class JogoDigital : Jogo
    {
        public JogoDigital()
        {
            
        }

        public JogoDigital(string nome, string plataforma) : base (nome, plataforma)
        {
            
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine
            ($"""
            === RESUMO EX-03 JOGO DIGITAL ===
            Nome: {Nome}
            Plataforma: {Plataforma}
            """);
        }
    }
}