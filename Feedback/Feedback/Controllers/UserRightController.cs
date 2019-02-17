using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;
namespace Feedback.Controllers
{
    public class UserRightController : Controller
    {
        // GET: UserRight
        private IRightInfoService _rightInfoService;
        public UserRightController(IRightInfoService rightInfoService)
        {
            _rightInfoService = rightInfoService;
        }
        public ActionResult Index()
        {
            var data = _rightInfoService.GetAllRights();
            return View(data);
        }
    }
}