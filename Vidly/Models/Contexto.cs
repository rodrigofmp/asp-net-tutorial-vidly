using System.Data.Entity;

namespace Vidly.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("name=Geral")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}