using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class Account:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public decimal Balance { get; set; }
        public string Photo { get; set; }
        public int NotificationStatus { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [ForeignKey("AccountType")]
        public int AccountTypeId { get; set; }
        public virtual AccountType AccountType { get; set; }

        [ForeignKey("AccountGroup")]
        public int Group { get; set; }
        public virtual AccountGroup AccountGroup { get; set; }

        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        
        
        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public string Country { get; set; }
        
    }
}