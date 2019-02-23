using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface IUserRoleService
    {
        List<UserRole> GetRoles();
    }
    public class UserRoleService : IUserRoleService
    {
        private IUserRoleRepo _userRoleRepo;
        public UserRoleService(IUserRoleRepo userRoleRepo)
        {
            _userRoleRepo = userRoleRepo;
        }
        public List<UserRole> GetRoles()
        {
            return _userRoleRepo.GetRoles();
        }
    }
}
