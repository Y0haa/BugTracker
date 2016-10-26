using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace BugTracker.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public ApplicationUser()
        {
            this.AssignedTickets = new HashSet<Ticket>();
            this.TicketAttachemts = new HashSet<TicketAttachments>();
            this.TicketComments = new HashSet<TicketComments>();
            this.TicketHistories = new HashSet<TicketHistory>();
            this.TicketNotificaitons = new HashSet<TicketNotification>();
        }

        //Connection to Tickets
        public virtual ICollection<Ticket> AssignedTickets { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachemts { get; set; }
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<TicketHistory> TicketHistories { get; set; }
        public virtual ICollection<TicketNotification> TicketNotificaitons { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
         
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        // This has to match with the Hashsets in the Models ---- This is the last step before Migrating to the Database
        public DbSet<Ticket> Ticekts { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<TicketAttachments> TicketAttachments { get; set; }
        public DbSet<TicketComments> TicketComments { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
        public DbSet<TicketNotification> TicketNotifications { get; set; }
        public DbSet<TicketPriority> TicketPriorities { get; set; }        
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Project> Projets { get; set; }

    }
}