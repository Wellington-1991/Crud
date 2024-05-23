using System.ComponentModel.DataAnnotations;

namespace ProjetoCrud.Entitie;
public class Cliente
{
    [Key]
    public int ID { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}