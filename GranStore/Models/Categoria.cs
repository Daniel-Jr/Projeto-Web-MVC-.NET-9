
using System.ComponentModel.DataAnnotations;

namespace GranStore.Models;

public class Categoria
{   
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }
}
