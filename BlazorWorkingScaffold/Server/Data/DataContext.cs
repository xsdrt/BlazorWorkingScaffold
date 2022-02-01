//Usings are now globably stored in the Programs.cs  This is a C# feature but not sure I like it for maitenance reasons...

namespace BlazorWorkingScaffold.Server.Data
{
    public class DataContext : DbContext  //Recomend you hoover over the DbContext to see the definition and what it does...
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee>? Employees { get; set; } //This is a representation of our entity as a table in the database...
    }
}
