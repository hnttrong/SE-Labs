using System.Data.Entity;

namespace DAL
{
    public class Lab4DbContext : DbContext
    {
        public Lab4DbContext() : base("name=Lab4ConnectionString")
        {
            Database.SetInitializer<Lab4DbContext>(null);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
