namespace Heranca_Exercicios
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine
            ("""
            === RESUMO EX-04 ===
            NOTIFIÇÃO SMS AQUI!
            """);
        }
    }
}