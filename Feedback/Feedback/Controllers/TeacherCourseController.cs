using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;

namespace Feedback.Controllers
{
    public class TeacherCourseController : Controller
    {
        private ITeacherCourseInfoService _teachercourseinfoservice;

        public TeacherCourseController(ITeacherCourseInfoService teachercourseinfoservice)
        {
            _teachercourseinfoservice = teachercourseinfoservice;
        }
        // GET: TeacherCourse
        public ActionResult Index()
        {
            var data = _teachercourseinfoservice.GetAllTeacherCourseInfo();
            return View(data);
        }
    }
}