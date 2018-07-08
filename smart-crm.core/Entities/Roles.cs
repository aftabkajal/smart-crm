using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Roles : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool ManageClient { get; set; }
        public bool ManageOrderAndInvoice { get; set; }
        public bool ManageSupport { get; set; }
        public bool ManageFinance { get; set; }
        public bool ManageProduct { get; set; }
        public bool ManageAdministrativeOptions { get; set; }
    }
}