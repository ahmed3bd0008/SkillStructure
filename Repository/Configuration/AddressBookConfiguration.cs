using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class AddressBookConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Room> builder)
        {
           
        }
    }
}