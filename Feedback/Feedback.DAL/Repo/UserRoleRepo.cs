using Feedback.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.DAL.Repo
{
    public interface IUserRoleRepo
    {
        List<UserRole> GetRoles();
    }
    public class UserRoleRepo : IUserRoleRepo
    {
        public List<UserRole> GetRoles()
        {
            List<UserRole> roles = new List<UserRole>();

            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                roles = _entities.UserRoles.ToList();
            }
            return roles;
        }
    }
}
