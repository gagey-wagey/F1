using Microsoft.EntityFrameworkCore;
using ProjectGrandPrix.Domain.Entities;

namespace ProjectGrandPrix.DataAccess.Context
{
    public class F1DbContext : DbContext
    {
        public F1DbContext(DbContextOptions<F1DbContext> options)
        : base(options)
        { }

        public DbSet<GrandPrix> GrandsPrix { get; set; }
    }
}