using Microsoft.EntityFrameworkCore;
using RetaguardaAPI.Entity.ModelBuilders;

namespace RetaguardaAPI.Entity;

public class dbContext : DbContext
{
    public dbContext(DbContextOptions<dbContext> options) : base(options) { }

    public DbSet<Paciente> Paciente { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new PacienteModelBuilder().create(modelBuilder);
    }
}
