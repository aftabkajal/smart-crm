using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace smart_crm.Infrastructure.Data
{
    public class RoleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RoleRepository()
        {
            this._dbContext = new ApplicationDbContext();
        }

        public async Task AddRoleAsync(IdentityRole Role)
        {
            _dbContext.Roles.Add(Role);
           await _dbContext.SaveChangesAsync();
        }
    }
}