using System.Data.Entity;
using System.Data.Entity.SqlServer;
using Microsoft.Data.SqlClient;
using Model;

namespace DataAccessLayer;

[DbConfigurationType(typeof(MicrosoftSqlDbConfiguration))]
public class Context : DbContext
{
    static Context()
    {
        Database.SetInitializer<Context>(null);
    }

    public Context(string connectionString)
        : base(new SqlConnection(connectionString), contextOwnsConnection: true)
    {
    }

    public DbSet<Student> Students { get; set; } = null!;

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("Students", "dbo");
        modelBuilder.Entity<Student>().HasKey(student => student.Id);

        base.OnModelCreating(modelBuilder);
    }
}