using Escola.domain.Entities;
using Escola.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.Data.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        Task<Turma> ITurmaRepository.AddAsync(Turma turma)
        {
            throw new NotImplementedException();
        }

        Task ITurmaRepository.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Turma>> ITurmaRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Turma> ITurmaRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Turma> ITurmaRepository.UpdateAsync(Turma turma)
        {
            throw new NotImplementedException();
        }
    }
}
