namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UtilizadoresDBcontext : DbContext
    {
        public UtilizadoresDBcontext()
            : base("name=UtilizadoresDBcontext")
        {
        }

        public virtual DbSet<Utilizadores> Utilizadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizadores>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizadores>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizadores>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Utilizadores>()
                .Property(e => e.tema_Ambiente)
                .IsUnicode(false);
        }
    }
}
