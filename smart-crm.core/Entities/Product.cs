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
        public string Details { get; set; }
        public string Variation { get; set; }

        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        public virtual Category ProductCategory { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public bool Status { get; set; }
        public bool ShowClient { get; set; }
        
    }
}