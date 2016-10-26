using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class TicketType
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Creating a Hash connector for the Child
        public TicketType()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        // Navigation connection to Child Ticket
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}