using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface ICourseInfoService
    {
        List<CourseInfo> GetAllCourse();
    }
  public  class CourseInfoService: ICourseInfoService
    {
        private ICourseRepo _courseRepo;
      public CourseInfoService(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
       public List<CourseInfo> GetAllCourse()
        {
            return _courseRepo.GetAllCourse();
        }
    }
}
