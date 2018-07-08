using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smart_crm.core.Entities
{
    public class PermissionRole:Entity
    {
        [ForeignKey("Permissions")]
        public int PermissionId { get; set; }
        public virtual Permissions Permissions { get; set; }

        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }
    }
}