using ProjetoAluno.Dominio.Dominio;

namespace ProjetoAluno.Models
{
    public class IndexView
    {
        public List<Aluno> Alunos { get; set; } = new();
        public int TotalItens { get; set; }
        public int PaginaAtual { get; set; }
        public int ItensPorPagina { get; set; }

        public int TotalPaginas => (int)Math.Ceiling((double)TotalItens / ItensPorPagina);
    }
}
