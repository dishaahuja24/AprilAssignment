using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeAssignmentQues2.Models;

namespace EmployeeAssignmentQues2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            Employee emp = new Employee();

            var e = emp.GetType();

            ViewBag.title = "Employee List";
            ViewBag.emp = e;

            




            return View();
        }
    }
}