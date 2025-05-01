using Microsoft.EntityFrameworkCore; // for DbContext

namespace Northwind.EntityModels;

/// <summary>
/// Represents the database context for the Northwind database.
/// This class provides access to the database and configures the connection.
/// </summary>
public class NorthwindDb : DbContext
{
    /// <summary>
    /// Configures the database connection for the Northwind database.
    /// </summary>
    /// <param name="optionsBuilder">
    /// A builder used to create or modify options for this context.
    /// </param>
    /// <remarks>
    /// Creates a SQLite database connection using a local database file named
    /// 'Northwind.db' in the current directory.
    /// </remarks>
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Northwind.db";
        string path = Path.Combine(
            Environment.CurrentDirectory, databaseFile);
            
        string connectionString = $"Data Source={path}";
        WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);
    }
}
