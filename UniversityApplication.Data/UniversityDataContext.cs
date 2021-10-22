using Microsoft.EntityFrameworkCore;
using UniversityApplication.Data.Configuration;
using UniversityApplication.Data.Models;

namespace UniversityApplication.Data
{
    public class UniversityDataContext : DbContext
    {
        public UniversityDataContext(DbContextOptions options) : base(options)
        {
        }

        public UniversityDataContext()
        {
            throw new System.NotImplementedException();
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Transcript> Transcripts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new TranscriptConfiguration());
        
        }
        
    }
}