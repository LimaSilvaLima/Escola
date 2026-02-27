using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.domain.Entities
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CursoId { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
        public string Curso Curso {get; set;}

    }
}
