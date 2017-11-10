using Microsoft.EntityFrameworkCore;
using Prototype1.Models;

namespace Prototype1.Data 
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiagnosisType> DiagnosisTypes { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnosis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<PatientDiagnosis>().ToTable("PatientDiagnosis");
            modelBuilder.Entity<DiagnosisType>().ToTable("DiagnosisTypes");
        }
    }

    
}
