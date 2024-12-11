var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Maiara.db>();
var app = builder.Build();

public class Maiara.db : DbContext
{
    public DbSet<Alunos> ALunos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Maiara.db");
    }
}