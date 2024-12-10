namespace ProjetoiImc.models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class Imc {

    [KEY]
    public int ImcId { get; set; }

    [Required]
    public double Altura { get; set; } = null!;

    [Required]
    public double Peso { get; set; } = null!;

    public DateTime CriadoEm { get; set; } = DateTime.Now;

}