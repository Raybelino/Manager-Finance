using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ManagerFinances.Entities;
using System.Collections.Generic;

public class Account
{
    // La columna primaria de la tabla account y se pone incremental automaticamente
    [Key]
    public int CuentaID { get; set; }

    // La columna que hace foreign key con la tabla usuario
    [Required]
    public int UsuarioID { get; set; }

    // La columna que almacena el nombre de la cuenta
    [Required, MaxLength(100)]
    public string Nombre { get; set; }

    // La columna que almacena el saldo de la cuenta
    [Required]
    public decimal Saldo { get; set; }

    // Se crea el foreign key con la tabla usuario
    [ForeignKey("UsuarioID")]
    public virtual User Usuario { get; set; }

    // Se implementa la relaccion que tiene las cuentas con las transacciones (1:N)
    public ICollection<Transaction> Transacciones { get; set; }
}

