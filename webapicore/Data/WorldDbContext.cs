using Microsoft.EntityFrameworkCore;
using webapicore.Models.Domains;

namespace webapicore.Data
{
    public class WorldDbContext : DbContext
    {
        public WorldDbContext(DbContextOptions options) : base(options)
        {

          
        }
        public DbSet<Band> bands { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Category> categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasOne(e=>e.ParentCategory).WithMany(e=>e.SubCategory).HasForeignKey(e=>e.ParentCategoryId);
           
            base.OnModelCreating(modelBuilder);
           
        }
    }
}
