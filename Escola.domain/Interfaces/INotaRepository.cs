using Escola.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.domain.Interfaces
{
    public interface INotaRepository
    {
        Task<Nota> GetByIdAsync(int  id);
        Task<List<Nota>> GetAllAsync();
        Task<Nota> AddAsync(Nota nota);
        Task<Nota> UpdateAsync(Nota nota);
        Task<Nota> DeleteAsync(int id);xxxxxxx                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
    }
}
