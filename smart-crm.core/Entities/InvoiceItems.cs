using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class InvoiceItems:Entity
    {
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public virtual Invoices Invoice { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}