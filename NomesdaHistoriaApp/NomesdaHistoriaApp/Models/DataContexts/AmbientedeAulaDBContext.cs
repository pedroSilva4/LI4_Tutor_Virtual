namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AmbientedeAulaDBContext : DbContext
    {
        public AmbientedeAulaDBContext()
            : base("name=AmbientedeAulaDBContext")
        {
        }

        public virtual DbSet<AmbientesDeAula> AmbientesDeAula { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmbientesDeAula>()
                .Property(e => e.tema)
                .IsUnicode(false);

            modelBuilder.Entity<AmbientesDeAula>()
                .Property(e => e.PATH)
                .IsUnicode(false);
        }
    }
}
