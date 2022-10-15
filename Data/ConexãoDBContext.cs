using LabClinic.Entitie;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace LabClinic.Data
{
    public class ConexãoDBContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Exame> Exames { get; set; }


     

    }
}
