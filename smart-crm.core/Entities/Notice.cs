using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Notice : Entity
    {
        public string Title { get; set; }
        public string ForClients { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }
    }
}