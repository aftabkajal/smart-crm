using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Order:Entity
    {
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Account Client { get; set; }

        public decimal Ammount { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

    }
}