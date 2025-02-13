﻿using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Entities;
using Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplo___Aplicação_Saga_Pattern.SagaPattern.Busisnes.Model.Repositorys.Implementations
{
    public class SaqueRepository : ISaqueRepository
    {
        void ISaqueRepository.Sacar(ContaBancaria conta, double valorSacar)
        {
            conta.saldo -= valorSacar;
        }
    }
}
