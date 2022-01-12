using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Data;

namespace WebApplication5.Areas.admin.Controllers
{[Area("admin")]
    public class EmployeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeController(AppDbContext context)
        {
           _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Employes.Include(u=>u.Position).ToList());
        }
    }
}
