using Microsoft.EntityFrameworkCore;

namespace RetaguardaAPI.Entity.ModelBuilders;

public class PacienteModelBuilder : IModelBuilderBase
{
    public void create(ModelBuilder builder)
    {
        builder.Entity<Paciente>(paciente =>
        {
            paciente.HasKey(i => i.Ide);
            
            paciente.Property(i => i.Ide)
                            .IsRequired(true); 
            
            paciente.Property(i => i.Id)
                            .IsRequired(true)
                            .HasColumnType("integer")
                            .ValueGeneratedOnAdd();

            paciente.Property(i => i.Name)
                            .IsRequired(true)
                            .HasColumnType("varchar(30)");

            paciente.Property(i => i.Description)
                            .IsRequired(true)
                            .HasColumnType("varchar(200)");

            paciente.Property(i => i.DateRegister)
                            .IsRequired(true)
                            .HasColumnType("datetime");

            paciente.Property(i => i.Status)
                            .HasColumnType("int")
                            .IsRequired(true);
        });
    }
}
