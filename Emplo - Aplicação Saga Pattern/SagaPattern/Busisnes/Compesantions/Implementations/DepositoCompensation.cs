using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Compesantions.Interfaces;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Compesantions.Implementations
{
    internal class DepositoCompensation : IDepositoCompensation
    {
        void IDepositoCompensation.CompensarDeposito(ContaBancaria conta, double saldoDepositar)
        {
            conta.saldo = saldoDepositar;
        }
    }
}
