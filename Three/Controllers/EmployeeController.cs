using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Three.Models;
using Three.Services;

namespace Three.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IDepartmentService departmentService,IEmployeeService employeeService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index(int departmentId)
        {
            ViewBag.Title = "Add Employee";
            return View(new Employee()
            {
                DepartmentId=departmentId
            });
        }
    }
}
