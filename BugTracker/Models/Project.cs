using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class Project
    {
        //TODO; Add Projects properties

        public int Id { get; set; }
        public string Name { get; set; }


        //The Constructor is alwasys the same name as the --Class--

            public Project()
        {
            this.Tickets = new HashSet<Ticket>();
            this.ApplicationUser = new HashSet<ApplicationUser>();
            
        }
            
         
        //TODO; Add Project navigation properties to Children
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}