namespace RetaguardaAPI.Entity;

public class Paciente
{
    public Guid Ide { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateRegister {  get; set; }
    public int Status { get; set; }

    public Paciente()
    {
        Ide = Guid.Empty;
        Id = 0;
        Name = string.Empty;
        Description = string.Empty;
        DateRegister = new DateTime(1900, 1, 1);
        Status = 0;
    }
}