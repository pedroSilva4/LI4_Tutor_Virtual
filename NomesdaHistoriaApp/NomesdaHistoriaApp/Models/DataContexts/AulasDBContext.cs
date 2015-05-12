namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AulasDBContext : DbContext
    {
        public AulasDBContext()
            : base("name=AulasDBContext")
        {
        }

        public virtual DbSet<Ajudas> Ajudas { get; set; }
        public virtual DbSet<Apresentacoes> Apresentacoes { get; set; }
        public virtual DbSet<Aulas> Aulas { get; set; }
        public virtual DbSet<Multimedia> Multimedia { get; set; }
        public virtual DbSet<Perguntas> Perguntas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ajudas>()
                .Property(e => e.ajuda)
                .IsUnicode(false);

            modelBuilder.Entity<Ajudas>()
                .Property(e => e.topico)
                .IsUnicode(false);

            modelBuilder.Entity<Ajudas>()
                .Property(e => e.audio)
                .IsUnicode(false);

            modelBuilder.Entity<Apresentacoes>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Apresentacoes>()
                .HasMany(e => e.Multimedia)
                .WithRequired(e => e.Apresentacoes)
                .HasForeignKey(e => new { e.apresentacoes_cod, e.apresentacoes_aula })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aulas>()
                .Property(e => e.personagem)
                .IsUnicode(false);

            modelBuilder.Entity<Aulas>()
                .HasMany(e => e.Ajudas)
                .WithRequired(e => e.Aulas)
                .HasForeignKey(e => e.aula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aulas>()
                .HasMany(e => e.Apresentacoes)
                .WithRequired(e => e.Aulas1)
                .HasForeignKey(e => e.aulas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aulas>()
                .HasMany(e => e.Perguntas)
                .WithRequired(e => e.Aulas)
                .HasForeignKey(e => e.aula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Multimedia>()
                .Property(e => e.texto)
                .IsUnicode(false);

            modelBuilder.Entity<Multimedia>()
                .Property(e => e.PATH)
                .IsUnicode(false);

            modelBuilder.Entity<Perguntas>()
                .Property(e => e.pergunta)
                .IsUnicode(false);

            modelBuilder.Entity<Perguntas>()
                .Property(e => e.resposta)
                .IsUnicode(false);

            modelBuilder.Entity<Perguntas>()
                .Property(e => e.errada1)
                .IsUnicode(false);

            modelBuilder.Entity<Perguntas>()
                .Property(e => e.errada2)
                .IsUnicode(false);

            modelBuilder.Entity<Perguntas>()
                .Property(e => e.errada3)
                .IsUnicode(false);
        }
    }
}
