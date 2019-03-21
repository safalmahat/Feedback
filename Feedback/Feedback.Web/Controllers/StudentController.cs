using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.DAL.Model;
using Feedback.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Feedback.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentInfoService _studentinfoservice;
        public StudentController(IStudentInfoService studentInfoService)
        {
            _studentinfoservice = studentInfoService;
        }

        public List<StudentInfo> GetData()
        {
            return _studentinfoservice.GetAllStudentInfo();
        }
      
    }
}