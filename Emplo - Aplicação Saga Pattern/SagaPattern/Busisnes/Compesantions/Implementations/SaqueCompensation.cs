using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Compesantions.Interfaces;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Compesantions.Implementations
{
    public class SaqueCompensation : ISaqueCompensation
    {
        void ISaqueCompensation.CompensarSaque(ContaBancaria conta, double SaldoOriginal)
        {
            conta.saldo = SaldoOriginal;
        }
    }
}
