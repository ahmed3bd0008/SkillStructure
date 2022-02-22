using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Repository.Configuration
{
    public class AddressBookConfiguration : IEntityTypeConfiguration<AddressBook>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AddressBook> builder)
        {
           
        }
    }
}