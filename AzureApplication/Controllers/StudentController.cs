using AzureApplication.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureApplication.Controllers
{
    public class StudentController : Controller
    {
        db_testEntities dbObj = new db_testEntities();
        // GET: Student
        public ActionResult Stduent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student student = new tbl_Student();
            student.Name = model.Name;
            student.Fname = model.Fname;
            student.Email = model.Email;
            student.Mobile = model.Mobile;
            student.Description = model.Description;
            dbObj.tbl_Student.Add(student);
            dbObj.SaveChanges();
            ModelState.Clear();

            return View("Stduent");
        }

        public ActionResult StduentList()
        {
            var result = dbObj.tbl_Student.ToList();
            return View(result);
        }
    }
}