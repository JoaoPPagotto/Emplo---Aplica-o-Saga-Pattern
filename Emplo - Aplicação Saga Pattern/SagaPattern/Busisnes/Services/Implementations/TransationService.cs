using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Implementations;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Interfaces;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Services.Interfaces;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Compesantions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Services.Implementations
{
    public class TransationService : ITransactionService
    {
        private readonly ISaqueRepository _saqueRepository;
        private readonly IDepositoRepository _depositoRepository;
        private readonly ISaqueCompensation _saqueCompensation;
        private readonly IDepositoCompensation _depositoCompensation;

        private TransationService(ISaqueRepository saqueRepository, IDepositoRepository depositoRepository,
            ISaqueCompensation saqueCompensation, IDepositoCompensation depositoCompensation)
        {
            _saqueRepository = saqueRepository;
            _depositoRepository = depositoRepository;
            _saqueCompensation = saqueCompensation;
            _depositoCompensation = depositoCompensation;
        }

        void ITransactionService.RealizarTransacao(ContaBancaria contaOrigem, ContaBancaria contaDestino, double valorTransferir)
        {
            double valorOrigem = contaOrigem.saldo;

            try
            {
                if (valorTransferir <= contaOrigem.saldo)
                {
                    Console.WriteLine("\n#INICIANDO SAQUE#\n");
                    _saqueRepository.Sacar(contaOrigem, valorTransferir);
                }
                else
                {
                    Console.WriteLine("\n#INICIANDO COMPENSACAO DO SAQUE#\n");
                    throw new Exception("Saldo menor que o valor para transferir");
                }
            }
            catch 
            {
                Console.WriteLine("\n#INICIANDO SAQUE#\n");
                _saqueCompensation.CompensarSaque(contaOrigem, valorOrigem);
                throw new Exception("Erro ao subtrair saldo da conta origem");
            }

            try
            {
                Console.WriteLine("\n#INICIANDO DEPOSITO#\n");
                _depositoRepository.Depositar(contaDestino, valorTransferir);
            }
            catch
            {
                Console.WriteLine("\n#INICIANDO COMPENSACAO DO DEPOSITO#\n");
                _depositoCompensation.CompensarDeposito(contaOrigem , valorOrigem);
                throw new Exception("Erro ao depositar valor na conta destino");
            }
        }
    }
}
