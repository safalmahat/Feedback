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
        bool Insert();
        UserInfo Login(string userName, string password);
        List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId);
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
        public bool Insert()
        {
            return _userRepo.Insert();
        }
        public UserInfo Login(string userName, string password)
        {
            return _userRepo.Login(userName, password);
        }
        public List<RoleAndRightsInfo> GetRightsByRoleId(int? roleId)
        {
            return _userRepo.GetRightsByRoleId(roleId);
        }
    }
}
