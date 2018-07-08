using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Invoices : Entity
    {
        public string Reference { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        [ForeignKey("Taxs")]
        public int TaxId { get; set; }
        public virtual Taxs Taxs { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("InvoiceStatuses")]
        public int invoice_status_id { get; set; }
        public virtual InvoiceStatuses InvoiceStatuses { get; set; }

        public DateTime DueDate { get; set; }
        public int RecurringStatus { get; set; }
        public string RecurringFrequency { get; set; }
        public int RecurringTimes { get; set; }
    }
}