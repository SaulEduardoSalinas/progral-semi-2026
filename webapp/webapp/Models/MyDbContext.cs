using Microsoft.EntityFrameworkCore;
namespace webapp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().ToTable("alumno").HasKey(a=>a.idAlumno);
            modelBuilder.Entity<Materia>().ToTable("Materia").HasKey(m=>m.idMateria);
            modelBuilder.Entity<Docente>().ToTable("Docente").HasKey(d=>d.idDocente);
        }
    }
}
