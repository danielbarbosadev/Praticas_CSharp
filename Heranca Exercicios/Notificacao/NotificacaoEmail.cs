namespace Heranca_Exercicios
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine
            ("""
            === RESUMO EX-04 ===
            NOTIFIÇÃO EMAIL AQUI!
            """);
        }
    }
}