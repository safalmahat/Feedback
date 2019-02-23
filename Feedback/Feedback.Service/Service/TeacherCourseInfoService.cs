using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;
using Feedback.DAL.Repo;

namespace Feedback.Service.Service
{
    public interface ITeacherCourseInfoService
    {
        List<TeacherCourseInfo> GetAllTeacherCourseInfo();
    }
    public class TeacherCourseInfoService:ITeacherCourseInfoService
    {
        private ITeacherCourseInfoRepo _teachercourseinfoservice;
        public TeacherCourseInfoService(ITeacherCourseInfoRepo teachercourseinfoservice)
        {
            _teachercourseinfoservice = teachercourseinfoservice;
        }

        public List<TeacherCourseInfo> GetAllTeacherCourseInfo()
        {
            return _teachercourseinfoservice.GetAllTeacherCourseInfo();
        }
    }
}
