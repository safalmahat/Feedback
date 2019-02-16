using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;
namespace Feedback.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: User
        public ActionResult Index()
        {
            return View(_userService.GetAllUser());
        }
        public ActionResult Insert()
        {
            _userService.Insert();
            return View();
        }
    }
}