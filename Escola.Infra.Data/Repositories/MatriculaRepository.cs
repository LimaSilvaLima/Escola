using Escola.domain.Entities;
using Escola.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.Data.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        Task<Matricula> IMatriculaRepository.AddAsync(Matricula matricula)
        {
            throw new NotImplementedException();
        }

        Task<Matricula> IMatriculaRepository.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Matricula>> IMatriculaRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Matricula> IMatriculaRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Matricula> IMatriculaRepository.UpdateAsync(Matricula matricula)
        {
            throw new NotImplementedException();
        }
    }
}
