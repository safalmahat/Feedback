using Feedback.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feedback.Controllers
{
    public class TeacherController : Controller
    {
        private ITeacherInfoService _teacherInfoService;

        public TeacherController(ITeacherInfoService teacherInfoService)
        {
            _teacherInfoService = teacherInfoService;
        }
        // GET: Teacher
        public ActionResult Index()
        {
            var data = _teacherInfoService.GetAllTeacherInfo();
            return View(data);
        }
    }
}