using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class TicketNotification
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int UserId { get; set; }

        // Creates a connection to the Parent
        public virtual Ticket Tickets { get; set; }

        // Create a Connection to the Parent User
        public virtual ApplicationUser User { get; set; }
    }
}