using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;
using Dapper;

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
            using (var _entities = new SqlConnection("Server=.;Database=FeedBack;Trusted_Connection=True;"))
            {

                lst = _entities.Query<StudentInfo>("select * from StudentInfo").ToList();
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
