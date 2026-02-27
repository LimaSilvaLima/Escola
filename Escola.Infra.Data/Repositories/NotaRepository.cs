using Escola.domain.Entities;
using Escola.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.Data.Repositories
{
    public class NotaRepository : INotaRepository
    {
        Task<Nota> INotaRepository.AddAsync(Nota nota)
        {
            throw new NotImplementedException();
        }

        Task<Nota> INotaRepository.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Nota>> INotaRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Nota> INotaRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Nota> INotaRepository.UpdateAsync(Nota nota)
        {
            throw new NotImplementedException();
        }
    }
}
