using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Recurrings:Entity
    {
        [ForeignKey("Invoices")]
        public int InvoiceId { get; set; }
        public virtual Invoices Invoices { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        [DataType(DataType.Date)]
        public DateTime NextDue { get; set; }

        [ForeignKey("RecurringTypes")]
        public int RecurringTypeId { get; set; }
        public virtual RecurringTypes RecurringTypes { get; set; }
        
        public int HowMany { get; set; }
        public int Note { get; set; }
    }
}