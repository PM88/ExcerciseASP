using System.Data.Entity.ModelConfiguration;
using ExcerciseASP.Models;

namespace ExcerciseASP.DataAccess.EntityConfigurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            HasKey(c => new { c.CountryCode });

            Property(c => c.CountryCode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2);

            Property(c => c.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
        }
    }
}