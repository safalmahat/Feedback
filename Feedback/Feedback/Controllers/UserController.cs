using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.DAL.Model;
using Feedback.Service.Service;
using Newtonsoft.Json;
using System.IO;
namespace Feedback.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        private IUserRoleService _userRoleService;
        public UserController(IUserService userService, IUserRoleService userRoleService)
        {
            _userService = userService;
            _userRoleService = userRoleService;
        }
        // GET: User
        public ActionResult Index()
        {
            List<UserRole> lstRoles = _userRoleService.GetRoles();
            ViewData["roles"] = new SelectList(lstRoles, "Id", "Name");
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login(UserInfo item)
        {
            ResponseModel resp = new ResponseModel();
            UserInfo user = _userService.Login(item.UserName, item.Password);
            if (user != null)
            {
                //fetch user rigths
                List<RoleAndRightsInfo> roleAndRights = _userService.GetRightsByRoleId(user.UserTypeId);
                //add right name to list of string
                List<string> rights = new List<string>();
                foreach (RoleAndRightsInfo roleAndRight in roleAndRights)
                {
                    rights.Add(roleAndRight.RightInfo.Name);
                }

                //store all rights in session
                Session["rights"] = rights;
                resp.success = true;
                resp.rights = rights;
                resp.message = "Login Successfully";
                return Json(resp,JsonRequestBehavior.AllowGet);
            }

            else
            {
                resp.success = false;
                resp.rights = null;
                resp.message = "Invalid User name or password";
            }
                return Json(resp, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Add()
        {

            List<UserRole> lstRoles = _userRoleService.GetRoles();
            ViewData["roles"] = new SelectList(lstRoles, "Id", "Name");
            return View();
        }
        [HttpPost]
        public bool Add(UserInfo userInfo, HttpPostedFileBase PhotoPath)
        {
            //string str = Request["userInfo"];

           //  userInfo = JsonConvert.DeserializeObject<UserInfo>(str);


            if (ModelState.IsValid)
            {
                if (PhotoPath != null)
                {
                    if (PhotoPath.ContentType == "image/jpeg"|| PhotoPath.ContentType == "image/png")
                    {

                        string pic = userInfo.Name + Path.GetExtension(PhotoPath.FileName);
                        string path = System.IO.Path.Combine(
                                                     Server.MapPath("~/UserPhoto"), pic);
                        // file is uploaded
                        PhotoPath.SaveAs(path);
                        userInfo.PhotoPath = "../UserPhoto/" + pic;
                    }
                }



                    if (userInfo.Id > 0)
                {
                    //edit
                    bool result = _userService.Edit(userInfo);
                    if (result)
                        return true;
                    else
                    {
                        List<UserRole> lstRoles = _userRoleService.GetRoles();
                        ViewData["roles"] = new SelectList(lstRoles, "Id", "Name");
                        return false;
                    }
                }
                else
                {
                    //add
                    bool result = _userService.Insert(userInfo);
                    if (result)
                        return true;
                    else
                    {
                        List<UserRole> lstRoles = _userRoleService.GetRoles();
                        ViewData["roles"] = new SelectList(lstRoles, "Id", "Name");
                        return false;
                    }
                }


            }
            else
            {

                List<UserRole> lstRoles = _userRoleService.GetRoles();
                ViewData["roles"] = new SelectList(lstRoles, "Id", "Name");
                return false;
            }

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            List<UserRole> lstRoles = _userRoleService.GetRoles();
            ViewData["roles"] = new SelectList(lstRoles, "Id", "Name");
            UserInfo userInfo = _userService.GetUser(id);
            return View("Add", userInfo);
        }
        public bool Delete(int id)
        {
            return _userService.Delete(id);
        }
        public string GetAllUser()
        {
            var data = _userService.GetAllUser();

            string list = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });


            return list;
        }
    }
    public class ResponseModel
    {
        public bool success { get; set; }
        public List<string> rights { get; set; }
        public string message { get; set; }
    }
}