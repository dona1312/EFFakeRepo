using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FakeProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class FakeUser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string FakeDate { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual IDbSet<FakeUser> FakeUsers { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}