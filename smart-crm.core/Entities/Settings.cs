using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Settings:Entity
    {
        public string CompanyName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyAddress { get; set; }

        [DataType(DataType.Url)]
        public string WebSite { get; set; }

        public string Country { get; set; }
        public string Currency { get; set; }
        public string WebsiteTitle { get; set; }
        public string BrandName { get; set; }

        public string CopyrightText { get; set; }
    }
}