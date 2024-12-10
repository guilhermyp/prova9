namespace Projetoimc.models;
using System.ComponentModel.DataAnnotations;
using System.Linq;


public class Aluno{

    [KEY]
    public int Alunoid {get; set;}

    [Required]
    public string NomeAluno { get; set; }

    [Required]
    public string SobrenomeAluno { get; set; }

    public int ImcId { get; set; } = null!;//chave estrangeira de imc
    
    public int ImcId ImcId { get; set; } = null!; // relacionamento
    
    public DateTime CriadoEm { get; set; } = DateTime.Now;

}