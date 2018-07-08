using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Faqs:Entity
    {
        public string Title { get; set; }

        [ForeignKey("FaqCategories")]
        public int FaqCategoryId { get; set; }
        public virtual FaqCategories FaqCategories { get; set; }
        public string Content { get; set; }
    }
}