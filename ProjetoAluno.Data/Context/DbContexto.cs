using Microsoft.EntityFrameworkCore;
using ProjetoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Data.Context
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions options)
            : base(options) 
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
