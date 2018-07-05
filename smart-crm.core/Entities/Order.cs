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
        public virtual Client Client { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        public decimal Quantity { get; set; }

        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public bool SendInvoice { get; set; }
    }
}