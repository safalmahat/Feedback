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
            return _userRepo.Insert(item);
        }
    }
}
