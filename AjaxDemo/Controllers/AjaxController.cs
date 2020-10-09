using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class AjaxController : Controller
    {
        //
        // GET: /Ajax/
        StudentContext objContext = new StudentContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            return PartialView("_Student",
                objContext.Students.ToList());
        }

        public PartialViewResult Top3()
        {
            return PartialView("_Student",
                objContext.Students.
                OrderByDescending(m => m.TotalMarks).Take(3).ToList());
        }

        public PartialViewResult Bottom3()
        {
            return PartialView("_Student",
                objContext.Students.OrderBy(m => m.TotalMarks).Take(3).ToList());
        }


        [HttpPost]
        public ActionResult Search(string SearchTerm)
        {
            List<Student> students;
            if (string.IsNullOrEmpty(SearchTerm))
            {
                students = objContext.Students.ToList();
            }
            else
            {
                students = objContext.Students.Where(m=>m.StudentName.Contains(SearchTerm)).ToList();
            }
            return PartialView("_Student", students);
        }
    }
}
