using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.SharedKernel
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public string Extra { get; set; }
    }
}