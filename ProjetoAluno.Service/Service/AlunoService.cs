using ProjetoAluno.Data.Repository.Interface;
using ProjetoAluno.Dominio.Dominio;
using ProjetoAluno.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Service.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void Adicionar(Aluno aluno)
        {
            _alunoRepository.Adicionar(aluno);
        }

        public List<Aluno> ListarAlunos(int paginaAtual, int itensPorPagina, out int totalItens)
        {
          return  _alunoRepository.ListarAlunos(paginaAtual, itensPorPagina, out totalItens);
        }
    }
}
