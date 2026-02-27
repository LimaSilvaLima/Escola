using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.domain.Entities
{
    public class Nota
    {
        public int Id { get; set; }
        public int MatriculaId { get; set; }
        public string Disciplina { get; set; }
        public int ValorNota { get; set; }
        public bool Aprovado { get; set; }
        public Matricula Matricula { get; set; }
       
    }
}
