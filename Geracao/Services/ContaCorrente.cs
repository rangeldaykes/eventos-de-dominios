using System;
using System.Collections.Generic;

namespace Geracao.Services {
    public class ContaCorrente 
    {
        public List<Lancamento> lancamentos { get; set; }
        public decimal Saldo { get; set; }

        public void Lancar (Lancamento lancamento) 
        {
            var saldoAnterior = this.Saldo;

            this.lancamentos.Add (lancamento);
            this.Saldo += lancamento.Valor;
        }
    }

    public class Lancamento 
    {
        public decimal Valor { get; set; }
    }
}