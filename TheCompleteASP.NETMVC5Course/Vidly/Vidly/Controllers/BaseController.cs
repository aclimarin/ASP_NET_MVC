using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using OverrideActionFiltersAttribute = System.Web.Http.OverrideActionFiltersAttribute;

namespace Vidly.Controllers
{
    public class BaseController: Controller
    {
        protected ApplicationDbContext _context;

        public BaseController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}