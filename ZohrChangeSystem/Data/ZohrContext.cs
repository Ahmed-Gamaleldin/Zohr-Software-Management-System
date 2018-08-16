using Microsoft.EntityFrameworkCore;
using ZohrChangeSystem.Data.Entities;

namespace ZohrChangeSystem.Data
{
    public class ZohrContext : DbContext
    {
        public ZohrContext(DbContextOptions<ZohrContext> options) : base(options)
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<ChangeForm> changeForms { get; set; }
    }
}
