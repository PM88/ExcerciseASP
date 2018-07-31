using System.Data.Entity.ModelConfiguration;
using ExcerciseASP.Models;

namespace ExcerciseASP.DataAccess.EntityConfigurations
{
    public class AddressTypeConfiguration : EntityTypeConfiguration<AddressType>
    {
        public AddressTypeConfiguration()
        {
            HasKey(a => new { a.AddressTypeId });

            Property(a => a.AddressTypeId)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(1);

            Property(a => a.Description)
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}