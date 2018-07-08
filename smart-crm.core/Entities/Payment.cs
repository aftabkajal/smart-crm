using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Payment :Entity
    {
        public string Name { get; set; }
        public string Setting { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }
    }
}