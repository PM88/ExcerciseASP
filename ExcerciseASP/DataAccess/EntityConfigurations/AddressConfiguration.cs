using System.Data.Entity.ModelConfiguration;
using ExcerciseASP.Models;

namespace ExcerciseASP.DataAccess.EntityConfigurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(a => new { a.CustomerId, a.AddressTypeId });

            HasRequired(a => a.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => new { a.CustomerId, a.Name })
                .WillCascadeOnDelete(true);

            Property(a => a.AddressTypeId)
                .HasColumnName("AddressType");
            HasRequired(a => a.AddressType)
                .WithMany(at => at.Addresses)
                .HasForeignKey(a => a.AddressTypeId)
                .WillCascadeOnDelete(false);

            Property(a => a.Street)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            Property(a => a.ZIP)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(a => a.City)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            Property(a => a.CountryCode)
                .HasColumnName("Country");
            HasOptional(a => a.CountryClass)
                .WithMany(co => co.Addresses)
                .HasForeignKey(c => c.CountryCode)
                .WillCascadeOnDelete(false);
        }
    }
}