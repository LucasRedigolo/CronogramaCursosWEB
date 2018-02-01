using CronogramaCursosWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace CronogramaCursosWEB.Dados {
    public class CronogramaContexto : DbContext {
        public CronogramaContexto (DbContextOptions<CronogramaContexto> options) : base (options) { }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Turmas> Turmas { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder){
            modelBuilder.Entity<Areas> ().ToTable("Areas");
            modelBuilder.Entity<Cursos> ().ToTable("Cursos");
            modelBuilder.Entity<Turmas> ().ToTable("Turmas");
        }
    }
}