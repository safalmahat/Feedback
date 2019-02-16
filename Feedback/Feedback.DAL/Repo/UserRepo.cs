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
        UserInfo Login(string userName, string password);
        List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId);
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
        public UserInfo Login(string userName, string password)
        {
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
               return _entities.UserInfoes.Where(x => x.UserName.Equals(userName) && x.Password.Equals(password)).SingleOrDefault();
               
            }
        }
        public List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId)
        {
            List<RoleAndRightsInfo> lst = new List<RoleAndRightsInfo>();
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                lst = _entities.RoleAndRightsInfoes.Include("RightInfo").Where(x => x.RoleId==roleId).ToList();
            }
            return lst;
        }
            
    }
}
