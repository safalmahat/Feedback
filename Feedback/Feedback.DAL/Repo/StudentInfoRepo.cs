using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;

namespace Feedback.DAL.Repo
{
    public interface IStudentInfoRepo
    {
        List<StudentInfo> GetAllStudentInfo();
        bool insert(StudentInfo studentInfo);
    }
    public class StudentInfoRepo:IStudentInfoRepo
    {
        public List<StudentInfo> GetAllStudentInfo()
        {
            List<StudentInfo> lst = new List<StudentInfo>();
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                lst = _entities.StudentInfoes.Include("CourseInfo").Include("TeacherInfo").ToList();
            }
            return lst;
        }

        public bool insert(StudentInfo studentInfo)
        {
            bool result;
            using (FeedBackEntities _entities=new FeedBackEntities())
            {
               _entities.StudentInfoes.Add(studentInfo);
                int count = _entities.SaveChanges();
                if (count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
