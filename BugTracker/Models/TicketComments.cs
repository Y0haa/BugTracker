using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class TicketComments
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int TicketId { get; set; }
        public int UserId { get; set; }

        // Connect to User tabel
        public ApplicationUser User { get; set; }
    }
}