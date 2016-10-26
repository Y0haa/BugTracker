using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class Ticket
    { 
        //TODO: Add Ticket properties (All the properties)
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int Description { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicektPriorityId { get; set; }
        public int TicketStatusId { get; set; }
        public string OwnerUserId { get; set; }
        public string AssignedToUserId { get; set; }

        // The hashset will enable the Icolleation to store the information in the database. (All the Hashets for the ICollections)
        public Ticket()
        {
            this.TicketAttachments = new HashSet<TicketAttachments>();
            this.TicketComments = new HashSet<TicketComments>();
            this.TicketHistories = new HashSet<TicketHistory>();
            this.TicketNotifications = new HashSet<TicketNotification>();
             

        }

        //Navigation properties for our children- Thses do not end up as SQL columns... (All the Children)
        public virtual ICollection<TicketAttachments> TicketAttachments { get; set; }        
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<TicketHistory> TicketHistories { get; set; }
        public virtual ICollection<TicketNotification> TicketNotifications { get; set; }

        //The connection to theUser table to track Owener and AssignedTo (asp.net users table (Created for us by the Entity Framework))
        public virtual ApplicationUser OwnerUser { get; set; }
        public virtual ApplicationUser  AssignedToUser { get; set; }
         
        //Navigation properties form parent
        public virtual Project Projects { get; set; }
        public virtual TicketStatus TicketStatuses { get; set; }
        public virtual TicketPriority TicketPriorities { get; set; }
        public virtual TicketType TicketTypes { get; set; }

    }
}