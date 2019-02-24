using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.DAL.Model;
using Feedback.Service.Service;

namespace Feedback.Controllers
{
    public class StudentController : Controller
    {
        private IStudentInfoService _studentinfoservice;
        private ICourseInfoService _courseInfoService;
        private ITeacherInfoService _teacherInfoService;

        public StudentController(IStudentInfoService studentInfoService, ICourseInfoService courseInfoService, ITeacherInfoService teacherInfoService)
        {
            _studentinfoservice = studentInfoService;
            _courseInfoService = courseInfoService;
            _teacherInfoService = teacherInfoService;
        }
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            var data = _studentinfoservice.GetAllStudentInfo();
            return View(data);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            List<CourseInfo> lstCourse = _courseInfoService.GetAllCourse();
            ViewData["allCourse"] = new SelectList(lstCourse, "Id", "Name");

            List<TeacherInfo> lstTeacher = _teacherInfoService.GetAllTeacherInfo();
            ViewData["allTeacher"] = new SelectList(lstTeacher, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(StudentInfo item)
        {
            bool result = _studentinfoservice.insert(item);
            if (ModelState.IsValid)
            {
                if (result)
                {
                    return View();
                }
                else
                    return View();
            }
            else
                return View();
        }
    }
}