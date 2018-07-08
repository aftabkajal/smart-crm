using smart_crm.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.Infrastructure.Data
{
    public class OrderRepository : EfRepository<Order>
    {
        public OrderRepository(): base(ApplicationDbContext.Create()) { }
    }
}