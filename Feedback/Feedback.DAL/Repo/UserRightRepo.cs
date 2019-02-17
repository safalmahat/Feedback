using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;

namespace Feedback.DAL.Repo
{
    public interface IUserRightRepo
    {
        List<RightInfo> GetAllRights();
    }
    public class UserRightRepo : IUserRightRepo
    {
        public List<RightInfo> GetAllRights()
        {
              using (FeedBackEntities _entites = new FeedBackEntities())
            {
                return _entites.RightInfoes.ToList();
            }
        }
    }
}
