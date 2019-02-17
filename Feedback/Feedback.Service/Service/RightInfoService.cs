using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface IRightInfoService
    {
        List<RightInfo> GetAllRights();
    }
    public class RightInfoService : IRightInfoService
    {
        private IUserRightRepo _userRightRepo;
        public RightInfoService(IUserRightRepo userRightRepo)
        {
            _userRightRepo = userRightRepo;
        }
        public List<RightInfo> GetAllRights()
        {
            List<RightInfo> list= _userRightRepo.GetAllRights();
            return list;
        }
    }
}
