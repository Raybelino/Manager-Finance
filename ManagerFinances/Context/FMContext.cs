using ManagerFinances.Entities;
using System.Data.Entity;

public class FMContext : DbContext
{
    // Se instancia el context de la base de datos y se inicializa la base de datos
    public FMContext() : base("name=MFDB") 
    {
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<FMContext, Configuration>());
    }

    // Se instancia la tabla o entity User (Usuario)
    public DbSet<User> Usuarios { get; set; }

    // Se instancia la tabla o entity Account (Cuenta)
    public DbSet<Account> Cuentas { get; set; }

    // Se instancia la tabla o entity Category (Categoria)
    public DbSet<Category> Categorias { get; set; }

    // Se instancia la tabla o entity Transaction (Transaccion)
    public DbSet<Transaction> Transacciones { get; set; }
}

