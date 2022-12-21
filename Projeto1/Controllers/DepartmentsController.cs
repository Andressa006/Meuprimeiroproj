using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Models;

namespace Projeto1.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department> ();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 1, Name = "Fashion" });

            return View(list);
        }
    }
}
