using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Notice : Entity
    {
        public string Title { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Account Client { get; set; } 
        public string Details { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
    }
}