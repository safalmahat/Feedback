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
    }
    public class UserService: IUserService
    {
        private UserRepo _userRepo;
        public UserService()
        {
            _userRepo = new UserRepo();
        }
        public List<UserInfo> GetAllUser()
        {
            return _userRepo.GetAllUser();
        }
    }
}
