using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Interfaces
{
    internal interface IDepositoRepository
    {
        void Depositar(ContaBancaria conta, double valorDepositar);
    }
}
