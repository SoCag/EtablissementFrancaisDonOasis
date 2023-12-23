using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetNote.Models;

public partial class EtablissementFrancaisDonOasisContext : DbContext
{
    public EtablissementFrancaisDonOasisContext()
    {
    }

    public EtablissementFrancaisDonOasisContext(DbContextOptions<EtablissementFrancaisDonOasisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Donneur> Donneurs { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Questionnaire> Questionnaires { get; set; }

    public virtual DbSet<Reponse> Reponses { get; set; }

    public virtual DbSet<ReponseQuestionnaire> ReponseQuestionnaires { get; set; }

    public virtual DbSet<SousQuestion> SousQuestions { get; set; }

    public virtual DbSet<TypeResultat> TypeResultats { get; set; }

    public virtual DbSet<ViewDataGridQuestionnaire> ViewDataGridQuestionnaires { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-N696JIM\\SQLEXPRESS;User ID=sa;Password=Ryanfatsuzeb267*;Database=EtablissementFrancaisDonOasis;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.IdCategorie).HasName("PK__Categori__8A3D24089477ED66");

            entity.ToTable("Categorie");

            entity.HasIndex(e => e.Categorie1, "UQ__Categori__11794113F525E30A").IsUnique();

            entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");
            entity.Property(e => e.Categorie1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("categorie");
            entity.Property(e => e.Ordre)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ordre");
        });

        modelBuilder.Entity<Donneur>(entity =>
        {
            entity.HasKey(e => e.IdDonneur).HasName("PK__Donneur__82A0428386C3AA1E");

            entity.ToTable("Donneur");

            entity.HasIndex(e => e.AdresseEmail, "UQ__Donneur__9EB32D5400710023").IsUnique();

            entity.Property(e => e.IdDonneur).HasColumnName("idDonneur");
            entity.Property(e => e.AdresseEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresseEmail");
            entity.Property(e => e.DateDeNaissance).HasColumnName("dateDeNaissance");
            entity.Property(e => e.MotDePasse)
                .IsUnicode(false)
                .HasColumnName("motDePasse");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("prenom");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.IdQuestion).HasName("PK__Question__1196F465D477EDBC");

            entity.ToTable("Question");

            entity.Property(e => e.IdQuestion).HasColumnName("idQuestion");
            entity.Property(e => e.Enonce)
                .IsUnicode(false)
                .HasColumnName("enonce");
            entity.Property(e => e.IdCategorie).HasColumnName("idCategorie");
            entity.Property(e => e.Ordre).HasColumnName("ordre");

            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.IdCategorie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Question__idCate__4D94879B");
        });

        modelBuilder.Entity<Questionnaire>(entity =>
        {
            entity.HasKey(e => e.IdQuestionnaire).HasName("PK__Question__609470D2A98E3B6A");

            entity.ToTable("Questionnaire");

            entity.Property(e => e.IdQuestionnaire).HasColumnName("idQuestionnaire");
            entity.Property(e => e.AccordPartage).HasColumnName("accordPartage");
            entity.Property(e => e.DateQuestionnaire)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("dateQuestionnaire");
            entity.Property(e => e.IdDonneur).HasColumnName("idDonneur");
            entity.Property(e => e.IdTypeResultat).HasColumnName("idTypeResultat");

            entity.HasOne(d => d.IdDonneurNavigation).WithMany(p => p.Questionnaires)
                .HasForeignKey(d => d.IdDonneur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Questionn__idDon__4E88ABD4");

            entity.HasOne(d => d.IdTypeResultatNavigation).WithMany(p => p.Questionnaires)
                .HasForeignKey(d => d.IdTypeResultat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Questionn__idTyp__4F7CD00D");
        });

        modelBuilder.Entity<Reponse>(entity =>
        {
            entity.HasKey(e => e.IdReponse).HasName("PK__Reponse__41D6459EE9903AD1");

            entity.ToTable("Reponse");

            entity.HasIndex(e => e.Reponse1, "UQ__Reponse__97B201E736284000").IsUnique();

            entity.Property(e => e.IdReponse).HasColumnName("idReponse");
            entity.Property(e => e.Reponse1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reponse");
        });

        modelBuilder.Entity<ReponseQuestionnaire>(entity =>
        {
            entity.HasKey(e => e.IdReponseQuestionnaire).HasName("PK__ReponseQ__34B35A23DE341CF9");

            entity.ToTable("ReponseQuestionnaire");

            entity.Property(e => e.IdReponseQuestionnaire).HasColumnName("idReponseQuestionnaire");
            entity.Property(e => e.Complement)
                .IsUnicode(false)
                .HasColumnName("complement");
            entity.Property(e => e.IdQuestionnaire).HasColumnName("idQuestionnaire");
            entity.Property(e => e.IdReponse).HasColumnName("idReponse");
            entity.Property(e => e.IdSousQuestion).HasColumnName("idSousQuestion");

            entity.HasOne(d => d.IdQuestionnaireNavigation).WithMany(p => p.ReponseQuestionnaires)
                .HasForeignKey(d => d.IdQuestionnaire)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ReponseQu__idQue__5070F446");

            entity.HasOne(d => d.IdReponseNavigation).WithMany(p => p.ReponseQuestionnaires)
                .HasForeignKey(d => d.IdReponse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ReponseQu__idRep__5165187F");

            entity.HasOne(d => d.IdSousQuestionNavigation).WithMany(p => p.ReponseQuestionnaires)
                .HasForeignKey(d => d.IdSousQuestion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ReponseQu__idSou__52593CB8");
        });

        modelBuilder.Entity<SousQuestion>(entity =>
        {
            entity.HasKey(e => e.IdSousQuestion).HasName("PK__SousQues__F5B46568AB03F4CF");

            entity.ToTable("SousQuestion");

            entity.Property(e => e.IdSousQuestion).HasColumnName("idSousQuestion");
            entity.Property(e => e.Enonce)
                .IsUnicode(false)
                .HasColumnName("enonce");
            entity.Property(e => e.IdQuestion).HasColumnName("idQuestion");
            entity.Property(e => e.NecessiteComplement).HasColumnName("necessiteComplement");
            entity.Property(e => e.Ordre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ordre");
            entity.Property(e => e.RendImpossible).HasColumnName("rendImpossible");

            entity.HasOne(d => d.IdQuestionNavigation).WithMany(p => p.SousQuestions)
                .HasForeignKey(d => d.IdQuestion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SousQuest__idQue__534D60F1");
        });

        modelBuilder.Entity<TypeResultat>(entity =>
        {
            entity.HasKey(e => e.IdTypeResultat).HasName("PK__TypeResu__5A6443E7F53E690C");

            entity.ToTable("TypeResultat");

            entity.HasIndex(e => e.Statut, "UQ__TypeResu__A8589223B1A0A831").IsUnique();

            entity.Property(e => e.IdTypeResultat).HasColumnName("idTypeResultat");
            entity.Property(e => e.Statut)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("statut");
        });

        modelBuilder.Entity<ViewDataGridQuestionnaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewDataGridQuestionnaire");

            entity.Property(e => e.Complement)
                .IsUnicode(false)
                .HasColumnName("complement");
            entity.Property(e => e.IdQuestionnaire).HasColumnName("idQuestionnaire");
            entity.Property(e => e.Question)
                .IsUnicode(false)
                .HasColumnName("question");
            entity.Property(e => e.RendImpossible).HasColumnName("rendImpossible");
            entity.Property(e => e.Reponse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reponse");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
