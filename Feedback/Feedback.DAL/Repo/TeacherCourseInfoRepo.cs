using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;

namespace Feedback.DAL.Repo
{
    public interface ITeacherCourseInfoRepo
    {
        List<TeacherCourseInfo> GetAllTeacherCourseInfo();
    }
    public class TeacherCourseInfoRepo:ITeacherCourseInfoRepo
    {
        List<TeacherCourseInfo> lst = new List<TeacherCourseInfo>();

        public List<TeacherCourseInfo> GetAllTeacherCourseInfo()
        {
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                lst = _entities.TeacherCourseInfoes.Include("TeacherInfo").Include("CourseInfo").ToList();
            }
            return lst;
        }

    }
}
