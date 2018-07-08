using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Permissions:Entity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}