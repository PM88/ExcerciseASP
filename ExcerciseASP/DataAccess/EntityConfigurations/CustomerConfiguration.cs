using System.Data.Entity.ModelConfiguration;
using ExcerciseASP.Models;

namespace ExcerciseASP.DataAccess.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => new { c.CustomerId, c.Name });

            Property(c => c.CustomerId)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(5);

            Property(c => c.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

        }
    }
}