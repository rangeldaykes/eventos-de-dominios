using System;
using System.Collections.Generic;

namespace Geracao.Services {
    public class ContaCorrente 
    {
        public ContaCorrente(string Nome)
        {
            this.NomeDoCliente = Nome;
        }

        public List<Lancamento> lancamentos { get; set; }
        public decimal Saldo { get; set; }
        public string NomeDoCliente { get; set; }

        public void Lancar (Lancamento lancamento) 
        {
            var saldoAnterior = this.Saldo;

            //this.lancamentos.Add(lancamento);
            this.Saldo += lancamento.Valor;

            DomainEvents.Raise(
                new SaldoDaContaAlterado(this.NomeDoCliente, saldoAnterior, this.Saldo));
        }

        public class Lancamento 
        {
            public Lancamento(string Descricao, decimal Valor)
            {
                this.Descricao = Descricao;
                this.Valor = Valor;
            }
            public string Descricao { get; set; }
            public decimal Valor { get; set; }
        }        
    }
}