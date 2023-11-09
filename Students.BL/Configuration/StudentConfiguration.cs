using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Students.BL.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .ToTable("student");

            builder
                .Property(p => p.Id)
                .HasColumnName("id")
                .HasColumnType("bigint")
                .IsRequired();

            builder
                .HasKey("Id");

            builder
                .Property(p => p.FullName)
                .HasColumnName("full_name")
                .HasColumnType("nvarchar(60)")
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasColumnName("description")
                .HasColumnType("nvarchar(200)");

            builder
                .Property(p => p.Course)
                .HasColumnName("course")
                .HasColumnType("bigint")
                .IsRequired();

            builder
                .Property(p => p.Stipend)
                .HasColumnName("stipend")
                .HasColumnType("bit");
        }
    }
}
