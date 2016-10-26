using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class TicketAttachments
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string FilePath { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }
        public string FileUrl { get; set; }
    

    // Connect to Parent Ticket
    public virtual Ticket Tickets { get; set; }

    // Connect to the User Table
    public virtual ApplicationUser User { get; set; }

    }

}