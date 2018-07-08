using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Transactions:Entity
    {
        [ForeignKey("TransactionTypes")]
        public int TransactionTypeId { get; set; }
        public virtual TransactionTypes TransactionTypes { get; set; }

        [ForeignKey("Invoices")]
        public int InvoiceId { get; set; }
        public virtual Invoices Invoices { get; set; }

        public int For { get; set; }
        
        public int From { get; set; }

        public decimal Amount { get; set; }
        public string Memo { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}