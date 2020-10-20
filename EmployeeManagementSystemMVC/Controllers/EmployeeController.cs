using EmpManagementBL;
using EmpManagementBL.implementation;
using EmpManagementML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystemMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmpManagementBusinessLayer empManagementBusinessLayer=new EmpManagementBusinessLayer();

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmpManagementModelLayer empManagementModelLayer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = empManagementBusinessLayer.AddEmployee(empManagementModelLayer);
                    if (result != null)
                    {
                        ViewBag.Message = "Employee Added Successfully!";
                    }
                }
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
