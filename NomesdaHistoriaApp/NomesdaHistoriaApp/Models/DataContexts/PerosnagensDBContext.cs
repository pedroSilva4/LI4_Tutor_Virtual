namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PerosnagensDBContext : DbContext
    {
        public PerosnagensDBContext()
            : base("name=PerosnagensDBContext")
        {
        }

        public virtual DbSet<Personagen> Personagens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagen>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Personagen>()
                .Property(e => e.sprite)
                .IsUnicode(false);
        }
    }
}
