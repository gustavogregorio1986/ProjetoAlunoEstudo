using System.ComponentModel.DataAnnotations;

namespace ProjetoAluno.Models
{
    public class AlunoView
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome do ALuno")]
        [Required(ErrorMessage = "Informe o Nome do Aluno")]
        public string? NomeAluno { get; set; }

        [Required(ErrorMessage = "Informe o Nota1 do Aluno")]
        public double Nota1 { get; set; }

        [Required(ErrorMessage = "Informe o Nota2 do Aluno")]
        public double Nota2 { get; set; }

        [Display(Name = "Total Media")]
        [Required(ErrorMessage = "Informe a media do Aluno")]
        public double TotalNota { get; set; }

        [Required(ErrorMessage = "Informe a situação do Aluno")]
        public string? Situacao { get; set; }

        [Display(Name = "Data de Inicio")]
        [Required(ErrorMessage = "Informe a Data de Inicio do Aluno")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de Termino")]
        [Required(ErrorMessage = "Informe a data de termino do Aluno")]
        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "Informe a escolaridade do Aluno")]
        public string? Escolaridade { get; set; }

        [Required(ErrorMessage = "Informe o status do Aluno")]
        public int Status { get; set; }
    }
}
