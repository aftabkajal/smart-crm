using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Taxs: Entity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}