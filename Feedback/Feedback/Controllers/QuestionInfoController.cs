using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;

namespace Feedback.Controllers
{
    public class QuestionInfoController : Controller
    {
        private IQuestionInfoService _questionInfoService;
        public QuestionInfoController(IQuestionInfoService questioninfoservice)
        {
            _questionInfoService = questioninfoservice;
        }
        // GET: QuestionInfo
        public ActionResult Index()
        {
            return View(_questionInfoService.GetAllQuestion());
        }
    }
}