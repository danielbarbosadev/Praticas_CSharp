using System.Data;

namespace Heranca_Exercicios.Documentos
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Exportar()
        {
            Console.WriteLine("Relatório Exportado!");
        }

        public void Imprimir()
        {
           Console.WriteLine("Relatório impresso!");
        }
    }
}