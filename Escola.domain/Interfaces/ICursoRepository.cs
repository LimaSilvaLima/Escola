using Escola.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.domain.Interfaces
{
    public interface ICursoRepository
    {
        Task<Curso> GetByIdAsync(int id);
        Task<List<Curso>> GetAllAsync();
        Task<Curso> addAsync(Curso curso);
        Task<Curso> UpdateAsync(Curso curso);
        Task<Curso> DeloeteAsync(int id);
    }
}
