using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class TicketMessages:Entity
    {
        [ForeignKey("Tickets")]
        public int TicketId { get; set; }
        public virtual Tickets Tickets { get; set; }

        public string Message { get; set; }

        public string MessageFrom { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Account User { get; set; }

        public DateTime Date { get; set; }

        public string File { get; set; }
    }
}