using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Exercicios
{
    public class JogoFisico : Jogo
    {
        public JogoFisico()
        {
            
        }

        public JogoFisico(string nome, string plataforma) : base (nome, plataforma)
        {
            
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine
            ($"""
            === RESUMO EX-03 JOGO FISICO ===
            Nome: {Nome}
            Plataforma: {Plataforma}
            """);
        }
    }
}