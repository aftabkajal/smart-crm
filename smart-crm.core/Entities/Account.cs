using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Account:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string AccountType { get; set; }
        public string Group { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public bool NotificationStatus { get; set; }
    }
}