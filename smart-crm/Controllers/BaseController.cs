using smart_crm.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smart_crm.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected RoleRepository roleRepository = new RoleRepository();
        public BaseController()
        {

        }
    }
}