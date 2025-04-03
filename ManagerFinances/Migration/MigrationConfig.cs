using System.Data.Entity.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<FMContext>
{
    // Esta clase permite que el context migre a la base de datos,
    // en otras palabras crea las entidades en la base de datos sqlserver
    public Configuration()
    {
        AutomaticMigrationsEnabled = true;
        AutomaticMigrationDataLossAllowed = true;
    }
}
