using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Expense
    {
        public DateTime IncomeDate { get; set; }
        public decimal Amount { get; set; }
        public string Memo { get; set; }
    }
}