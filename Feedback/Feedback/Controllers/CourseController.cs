using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;
namespace Feedback.Controllers
{
    public class CourseController : Controller
    {
        private ICourseInfoService _courseInfoService;
        public CourseController(ICourseInfoService courseInfoService)
        {
            _courseInfoService = courseInfoService;
        }
        // GET: Course
        public ActionResult Index()
        {
            var data = _courseInfoService.GetAllCourse();
            return View(data);
        }
    }
}