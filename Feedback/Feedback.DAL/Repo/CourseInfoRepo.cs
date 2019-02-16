using Feedback.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.DAL.Repo
{
    public interface ICourseRepo
    {
        List<CourseInfo> GetAllCourse();
    }
   public class CourseInfoRepo: ICourseRepo
    {
        public List<CourseInfo> GetAllCourse()
        {
            List<CourseInfo> lst = new List<CourseInfo>();
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                lst = _entities.CourseInfoes.ToList();
            }
            return lst;
        }
    }
}
