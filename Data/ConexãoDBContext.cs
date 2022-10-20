using LabClinic.Entitie;
using Microsoft.EntityFrameworkCore;


namespace LabClinic.Data
{
    public class ConexãoDBContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Exame> Exames { get; set; }
        

        public ConexãoDBContext(DbContextOptions<ConexãoDBContext> options) : base(options)
        {

        }

       protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>()
                .Property(p => p.Codigo).IsRequired();
            modelBuilder.Entity<Paciente>()
                .Property(p => p.DataNascimento).IsRequired();
           
        }

    }
}
