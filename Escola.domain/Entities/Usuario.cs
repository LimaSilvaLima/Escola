using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash {get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Perfil { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }


}
