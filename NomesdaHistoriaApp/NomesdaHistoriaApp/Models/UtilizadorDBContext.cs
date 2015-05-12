namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UtilizadorDBContext : DbContext
    {
        public UtilizadorDBContext()
            : base("name=UtilizadorDBContext")
        {
        }

        public virtual DbSet<Utilizador> Utilizadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizador>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizador>()
                .Property(e => e.tema_Ambiente)
                .IsUnicode(false);
        }
    }
}
