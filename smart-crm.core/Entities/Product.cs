using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Product: Entity
    {
        public string Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string Details { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public bool IsDisplay { get; set; }
        public bool IsProductOrService { get; set; }
        
    }
}