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
    }
}
