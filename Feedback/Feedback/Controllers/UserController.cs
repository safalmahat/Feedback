using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.DAL.Model;
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
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserInfo item)
        {
            UserInfo user = _userService.Login(item.UserName, item.Password);
            if(user!=null)
            {
                //fetch user rigths
              List<RoleAndRightsInfo> roleAndRights=  _userService.GetRightsByRoleId(user.UserTypeId);
                //add right name to list of string
                List<string> rights = new List<string>();
                foreach (RoleAndRightsInfo roleAndRight in roleAndRights)
                {
                    rights.Add(roleAndRight.RightInfo.Name);
                }
                
                //store all rights in session
                Session["rights"] = rights;

                return RedirectToAction("Index", "Home");
            }

           
            else
            return View();
        }
    }
}