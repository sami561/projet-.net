using Microsoft.EntityFrameworkCore;
using project.Models;

public class SoutenanceContext : DbContext
{
    public SoutenanceContext(DbContextOptions<SoutenanceContext> options)
        : base(options)
    {
    }

    public DbSet<ENSEIGNANT> Enseignants { get; set; }
    public DbSet<PFE> PFEs { get; set; }
    public DbSet<PFE_ETUDIANT> PFE_Etudiants { get; set; }
    public DbSet<ETUDIANT> Etudiants { get; set; }
    public DbSet<SOCIETE> Societes { get; set; }
    public DbSet<SOUTENANCE> Soutenances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define relationships, constraints, etc.
        modelBuilder.Entity<PFE>()
            .HasOne(p => p.Encadrant)
            .WithMany(e => e.PFEsEncadres)
            .HasForeignKey(p => p.EncadreurID);

        modelBuilder.Entity<PFE_ETUDIANT>()
            .HasKey(pe => new { pe.PFEID, pe.EtudiantId });

        modelBuilder.Entity<PFE_ETUDIANT>()
            .HasOne(pe => pe.PFE)
            .WithMany(p => p.PFE_Etudiants)
            .HasForeignKey(pe => pe.PFEID);

        modelBuilder.Entity<PFE_ETUDIANT>()
            .HasOne(pe => pe.Etudiant)
            .WithMany(e => e.PFE_Etudiants)
            .HasForeignKey(pe => pe.EtudiantId);

        modelBuilder.Entity<SOUTENANCE>()
            .HasOne(s => s.PFE)
            .WithMany(p => p.Soutenances)
            .HasForeignKey(s => s.PFEID);

        modelBuilder.Entity<SOUTENANCE>()
            .HasOne(s => s.President)
            .WithMany()
            .HasForeignKey(s => s.PresidentId);

        modelBuilder.Entity<SOUTENANCE>()
            .HasOne(s => s.Rapporteur)
            .WithMany()
            .HasForeignKey(s => s.RapporteurID);
    }
}
