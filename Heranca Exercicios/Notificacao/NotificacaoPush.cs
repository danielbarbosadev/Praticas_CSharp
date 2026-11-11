namespace Heranca_Exercicios
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine
            ("""
            === RESUMO EX-04 ===
            NOTIFIÇÃO PUSH AQUI!
            """);
        }
    }
}