using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Tickets:Entity
    {
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Account Client { get; set; }

        public string Subject { get; set; }

        [ForeignKey("TicketCategories")]
        public int TicketCategoryId { get; set; }
        public virtual TicketCategories TicketCategories { get; set; }

        public int Status { get; set; }
        public int Answered { get; set; }
    }
}