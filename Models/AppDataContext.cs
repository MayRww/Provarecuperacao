using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Maiara.db");
    }

    public class Aluno
{
	public int Id { get; set; }
	public string Nome { get; set; }
	public decimal Imc { get; set; }
}
}