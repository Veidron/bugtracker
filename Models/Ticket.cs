﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bug_tracker.Models
{
    public class Ticket
    {
        public Ticket()
        {
            this.Comments = new HashSet<TComment>();
        }

        public int Id { get; set; }
        public System.DateTimeOffset Created { get; set; }
        public Nullable<System.DateTimeOffset> Updated { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int ProjectId { get; set; }
        public int TypeId { get; set; }
        public int PriorityId { get; set; }
        public int StatusId { get; set; }
        public int OwnerId { get; set; }
        public int AssignedToUserId { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<TComment> Comments { get; set; }
    }
}