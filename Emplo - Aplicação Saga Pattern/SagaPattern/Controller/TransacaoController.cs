using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Compesantions.Interfaces;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Interfaces;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Services.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Controller
{
    public class TransacaoController
    {
        private readonly ITransactionService _transactionService;
        private TransacaoController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public void RealizaTransacao(ContaBancaria contaOrigem, ContaBancaria contaDestino, double valorTransferir)
        {
            Console.WriteLine("\n#INICIANDO TRANSAÇÃO#\n");
            _transactionService.RealizarTransacao(contaOrigem, contaDestino, valorTransferir);
        }
    }
}
