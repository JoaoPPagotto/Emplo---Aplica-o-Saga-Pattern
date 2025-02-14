using Emplo___Aplicação_Saga_Pattern.SagaPattern.Controller;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Services.Interfaces;

namespace SagaPattern
{
    internal class Program
    {
        private readonly TransacaoController _transacaoController;
        private Program(TransacaoController transacaoController)
        {
            _transacaoController = transacaoController;
        }
        static void Main(string[] args)
        {

            var contaOrigem = new ContaBancaria { saldo = 120 };
            var contaDestino = new ContaBancaria { saldo = 50 };
            double valorTransacao = 50;

            program._transacaoController.RealizaTransacao(contaOrigem, contaDestino, valorTransacao);
        }
    }
}
