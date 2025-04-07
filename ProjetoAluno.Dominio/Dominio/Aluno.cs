using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Dominio.Dominio
{
    public class Aluno
    {
        public Guid Id { get; set; }

        public string? NomeAluno { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double TotalNota { get; set; }

        public string? Situacao { get; set; }
    }
}
