using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface IUserService
    {
        List<UserInfo> GetAllUser();
        UserInfo Login(string userName, string password);
        List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId);
        bool Insert(UserInfo item);
        UserInfo GetUser(int id);
        bool Edit(UserInfo item);
        bool Delete(int id);
    }
    public class UserService: IUserService
    {
        private IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public List<UserInfo> GetAllUser()
        {
            return _userRepo.GetAllUser();
        }
        public UserInfo Login(string userName, string password)
        {
            return _userRepo.Login(userName, password);
        }
        public List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId)
        {
            return _userRepo.GetRightsByRoleId(roleId);
        }

        public bool Insert(UserInfo item)
        {
            if (item.Gender == null)
                item.Gender = true;
            return _userRepo.Insert(item);
        }

        public UserInfo GetUser(int id)
        {
            return _userRepo.GetUser(id);
        }

        public bool Edit(UserInfo item)
        {
            return _userRepo.Edit(item);
        }

        public bool Delete(int id)
        {
            return _userRepo.Delete(id);
        }
    }
}
