using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface ITeacherInfoService
    {
        List<TeacherInfo> GetAllTeacherInfo();
    }
    public class TeacherInfoService:ITeacherInfoService
    {
        private ITeacherInfoRepo _teacherInfo;
        public TeacherInfoService(ITeacherInfoRepo teacherInfo)
        {
            _teacherInfo = teacherInfo;
        }
        public List<TeacherInfo> GetAllTeacherInfo()
        {
            return _teacherInfo.GetAllTeacherInfo();
        }
    }
}
