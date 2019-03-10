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
        UserInfo Login(string userName, string password);
        List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId);
        bool Insert(UserInfo item);
        UserInfo GetUser(int id);
        bool Edit(UserInfo userInfo);
        bool Delete(int id);
    }
    public class UserRepo : IUserRepo
    {

        public List<UserInfo> GetAllUser()
        {
            List<UserInfo> lst = new List<UserInfo>();
            FeedBackEntities _entities = new FeedBackEntities();
             lst = _entities.UserInfoes.Include("UserRole").ToList();
            return lst;
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
                lst = _entities.RoleAndRightsInfoes.Include("RightInfo").Where(x => x.RoleId == roleId).ToList();
            }
            return lst;
        }

        public bool Insert(UserInfo item)
        {
            bool result;
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                _entities.UserInfoes.Add(item);
                int count = _entities.SaveChanges();
                if (count > 0)
                    result = true;
                else
                    result = false;
            }
            return result;
        }

        public UserInfo GetUser(int id)
        {
            UserInfo userInfo = new UserInfo();
            using (FeedBackEntities _entites = new FeedBackEntities())
            {
                userInfo = _entites.UserInfoes.Find(id);
            }
            return userInfo;
        }

        public bool Edit(UserInfo userInfo)
        {
            bool result;
            using (FeedBackEntities _entites = new FeedBackEntities())
            {
                _entites.Entry(userInfo).State = System.Data.Entity.EntityState.Modified;
                int count = _entites.SaveChanges();
                if (count > 0)
                    result = true;
                else
                    result = false;
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result;
            using (FeedBackEntities _entites = new FeedBackEntities())
            {
                UserInfo userInfo = _entites.UserInfoes.Find(id);
                _entites.UserInfoes.Remove(userInfo);
                int count = _entites.SaveChanges();
                if (count > 0)
                    result = true;
                else
                    result = false;
            }
            return result;
        }
    }
}
