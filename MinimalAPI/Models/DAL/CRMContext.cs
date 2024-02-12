using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models.EN;

namespace MinimalAPI.Models.DAL
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
