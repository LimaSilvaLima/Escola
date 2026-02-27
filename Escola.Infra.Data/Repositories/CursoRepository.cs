using Escola.domain.Entities;
using Escola.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        Task<Curso> ICursoRepository.addAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        Task<Curso> ICursoRepository.DeloeteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Curso>> ICursoRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Curso> ICursoRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Curso> ICursoRepository.UpdateAsync(Curso curso)
        {
            throw new NotImplementedException();
        }
    }
}
