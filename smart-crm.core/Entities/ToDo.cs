﻿using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class ToDo:Entity
    {
        public String Title { get; set; }
        public int Active { get; set; }
    }
}