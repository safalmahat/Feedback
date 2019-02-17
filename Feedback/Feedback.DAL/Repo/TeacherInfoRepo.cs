using Feedback.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.DAL.Repo
{
    public interface ITeacherInfoRepo
    {
        List<TeacherInfo> GetAllTeacherInfo();
    }
    public class TeacherInfoRepo:ITeacherInfoRepo
    {

        public List<TeacherInfo> GetAllTeacherInfo()
        {
            List<TeacherInfo> lst = new List<TeacherInfo>();
            using (FeedBackEntities feedBackEntities = new FeedBackEntities())
            {
                lst = feedBackEntities.TeacherInfoes.ToList();
            }
            return lst;
        }
    }
}
