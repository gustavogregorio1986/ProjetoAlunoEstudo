using ProjetoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Data.Repository.Interface
{
    public interface IAlunoRepository
    {
        void Adicionar(Aluno aluno);

        List<Aluno> ListarAlunos(int paginaAtual, int itensPorPagina, out int totalItens);
    }
}
