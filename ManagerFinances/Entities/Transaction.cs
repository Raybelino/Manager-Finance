using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
public class Transaction
{
    // La columna primaria de la tabla Transaccion y se pone incremental automaticamente
    [Key]
    public int TransaccionID { get; set; }

    // La columna que hace foreign key con la tabla Cuentas
    [Required]
    public int CuentaID { get; set; }

    // La columna que hace foreign key con la tabla Categorias
    [Required]
    public int CategoriaID { get; set; }

    // La columna que almacena el monto de la transaccion
    [Required]
    public decimal Monto { get; set; }

    // La columna que almacena la fecha automaticamente de la transaccion
    [Required]
    public DateTime Fecha { get; set; } = DateTime.Now;

    // La columna que almacena la descripcion de la transaccion
    public string Descripcion { get; set; }

    // Se crea el foreign key con la tabla Cuentas
    [ForeignKey("CuentaID")]
    public Account Cuenta { get; set; }

    // Se crea el foreign key con la tabla Categorias
    [ForeignKey("CategoriaID")]
    public Category Categoria { get; set; }
}
