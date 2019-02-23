using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;

namespace Feedback.Controllers
{
    public class StudentController : Controller
    {
        private IStudentInfoService _studentinfoservice;

        public StudentController(IStudentInfoService studentInfoService)
        {
            _studentinfoservice = studentInfoService;
        }
        // GET: Student
        public ActionResult Index()
        {
            var data = _studentinfoservice.GetAllStudentInfo();
            return View(data);
        }
    }
}