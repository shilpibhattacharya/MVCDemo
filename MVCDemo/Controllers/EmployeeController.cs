using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext context;
        public EmployeeController(EmployeeContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            //EmployeeContext context = new EmployeeContext();
            var emp = context.Departments.ToList();
            return View(emp);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department dep)
        {
            if (ModelState.IsValid)
            {
                //EmployeeContext context = new EmployeeContext();
                context.Add<Department>(dep);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return PartialView("ErrorMessage");
        }

        [HttpGet]
        public IActionResult Edit(int DepartmentId)
        {
            //EmployeeContext context = new EmployeeContext();
            var depDetail = context.Find<Department>(DepartmentId);
            return View(depDetail);
        }

        [HttpPost]
        public IActionResult Edit(Department dep)
        {
            if (ModelState.IsValid)
            {
                //EmployeeContext context = new EmployeeContext();
                context.Update<Department>(dep);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return PartialView("ErrorMessage");
        }


        public IActionResult Delete(int DepartmentId)
        {
            //EmployeeContext context = new EmployeeContext();
            var deleteDetail = context.Find<Department>(DepartmentId);
            context.Remove<Department>(deleteDetail);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}