using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Interfaces
{
    public interface ISaqueRepository
    {
        void Sacar(ContaBancaria conta, double valorSacar);
    }
}
