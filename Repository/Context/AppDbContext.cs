using System;
using Entity.Core;
using Entity.Core.authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository.Context
{
    public class AppDbContextTest : IdentityDbContext<userIdentity,roleIdentity,string>
    {
        public AppDbContextTest(DbContextOptions<AppDbContextTest> options):base(options)
        {
            
        }
      public   DbSet<Room>Rooms{set; get;}
      public   DbSet<RoomType>RoomTypes{set; get;}
      public   DbSet<RatePerRoom>RatePerRooms{set; get;}
    protected  override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AddressBookConfiguration());
    }

    }
}