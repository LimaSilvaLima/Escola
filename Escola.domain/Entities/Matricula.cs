using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Escola.domain.Entities
{
    public class Matricula
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int TurmaId {get; set; }
        public DateTime DataMatricula { get; set; }
        public DateTime DataExpiracao { get; set; }
        public bool Ativa { get; set; }
        public ICollection<Nota> Notas { get; set; }
        public Usuario Usuario { get; set; }
        public Turma Turma { get; set; }
        
    }
}
