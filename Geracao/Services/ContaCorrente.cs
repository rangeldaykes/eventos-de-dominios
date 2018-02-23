using System;

namespace Geracao.Services
{
    public class ContaCorrente
    {
        public void Lancar(Lancamento lancamento)
        {
            var saldoAnterior = this.Saldo;

            this.lancamentos.Add(lancamento);
            this.Saldo += lancamento.Valor;
        }
    }
}