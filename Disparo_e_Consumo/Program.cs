using System;
using Geracao.Services;

namespace Geracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cc = new ContaCorrente("rangel");
            cc.Lancar(new ContaCorrente.Lancamento("Conta Gás", -1000M));
            

            System.Console.ReadLine();
        }
    }
}
