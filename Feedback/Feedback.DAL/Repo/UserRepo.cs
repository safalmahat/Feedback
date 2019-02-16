using Feedback.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.DAL.Repo
{
    public interface IUserRepo
    {
        List<UserInfo> GetAllUser();
        bool Insert();
    }
  public  class UserRepo: IUserRepo
    {

        public List<UserInfo> GetAllUser()
        {
            List<UserInfo> lst = new List<UserInfo>();
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                lst = _entities.UserInfoes.Include("UserRole").ToList();
            }
            return lst;
        }
        public  bool Insert()
        {
            //TOD: insert code
            return true;
        }
    }
}
