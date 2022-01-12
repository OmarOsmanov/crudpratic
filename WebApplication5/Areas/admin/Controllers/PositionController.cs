using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Areas.admin.Controllers
{
    [Area("admin")]
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Positions.ToList());
        }


        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Position model)
        {
            if (ModelState.IsValid)
            {
                _context.Positions.Add(model);
                _context.SaveChanges();
                return RedirectToAction();
            }
            else
            {
                return View(model);
            }


            
        }


        [HttpGet]

        public IActionResult Update(int id)
        {

            return View(_context.Positions.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Position model)
        {
            if (ModelState.IsValid)
            {
                _context.Positions.Update(model);
                _context.SaveChanges();
                return RedirectToAction();
            }
            else
            {
                return View(model);
            }



        }
        public IActionResult Delete(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }


            Position position = _context.Positions.Find(id);

            if(position==null)
            {
                return NotFound();
            }

            _context.Positions.Remove(position);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
