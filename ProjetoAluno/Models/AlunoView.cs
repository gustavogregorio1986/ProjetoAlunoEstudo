namespace ProjetoAluno.Models
{
    public class AlunoView
    {
        public Guid Id { get; set; }

        public string? NomeAluno { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double TotalNota { get; set; }

        public string? Situacao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public string? Escolaridade { get; set; }

        public string? Status { get; set; }
    }
}
