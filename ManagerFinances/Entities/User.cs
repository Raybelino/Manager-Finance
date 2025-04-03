using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerFinances.Entities
{
    public class User
    {
        // La columna primaria de la tabla Usuario y se pone incremental automaticamente
        [Key]
        public int UsuarioID { get; set; }

        // La columna que almacena el nombre del usuario
        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        // La columna que almacena el correo del usuario,
        // esta columna tendra correo que sean unicos, que no se van a repetir
        [Required, MaxLength(100)]
        [Index(IsUnique = true)]
        public string Correo { get; set; }

        // La columna que almacena la contraseña del usuario
        [Required]
        public string Clave { get; set; }

        // Se implementa la relaccion que tiene los usuarios con las cuentas (1:N)
        public ICollection<Account> Cuentas { get; set; }
    }
}
