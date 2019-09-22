using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    //The IdentityDbContext is the gateway to our database. It is part of Asp.net identity framework.
    //So when we execute enable-migration, Entity Framework (EF) looked at our IdentityDbContext and it discovered
    //Db sets in IdentityDbContext like user, role, etc.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Add DbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}