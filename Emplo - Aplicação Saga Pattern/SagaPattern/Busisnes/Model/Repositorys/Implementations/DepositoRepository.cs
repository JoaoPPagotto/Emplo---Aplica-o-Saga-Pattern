using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Implementations
{
    public class DepositoRepository : IDepositoRepository
    {
        void IDepositoRepository.Depositar(ContaBancaria conta, double valorDepositar)
        {
            double valorOriginal = conta.saldo;
            conta.saldo += valorDepositar;
            Console.WriteLine("\nSaldo original da conta : " + valorOriginal + "\n Valor a depositar: " + valorDepositar + "\nNovo saldo: " + conta.saldo);
        }
    }
}
