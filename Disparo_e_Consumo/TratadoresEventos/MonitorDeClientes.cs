using System;

public class MonitorDeClientes : IHandler<SaldoDaContaAlterado>
{
    public void Handler(SaldoDaContaAlterado @event)
    {
        if (@event.SaldoAtual < @event.SaldoAnterior)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "Monitorando o Cliente {0}. Saldo: {1:N2}",
                @event.NomeDoCliente,
                @event.SaldoAtual);
 
            Console.ResetColor();            
        }
    }
}