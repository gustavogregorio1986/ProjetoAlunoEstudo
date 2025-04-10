using ProjetoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Service.Service.Interface
{
    public interface IAlunoService
    {
        void Adicionar(Aluno aluno);

        List<Aluno> ListarAlunos(int paginaAtual, int itensPorPagina, out int totalItens);

        List<Aluno> ListarAtivos(int paginaAtual, int itensPorPagina, int ativo, out int totalItens);

        List<Aluno> ListarInativos(int paginaAtual, int itensPorPagina, int inativo, out int totalItens);
    };
}
