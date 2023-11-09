using Microsoft.EntityFrameworkCore;
using Students.BL.Configuration;

namespace Students.BL
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base() { }
        public StudentDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(new ConnectionStringConfig().ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
    }
}
