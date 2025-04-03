using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
{
    // La columna primaria de la tabla Categoria y se pone incremental automaticamente
    [Key]
    public int CategoriaID { get; set; }

    // La columna que almacena el nombre de la categoria
    [Required, MaxLength(100)]
    public string Nombre { get; set; }

    // La columna que almacena el tipo de la categoria
    [Required]
    public char Tipo { get; set; }

    // Se implementa la relaccion que tiene las categorias con las transacciones (1:N)
    public ICollection<Transaction> Transacciones { get; set; }
}
