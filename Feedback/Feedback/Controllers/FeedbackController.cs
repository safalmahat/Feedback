using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback.Service.Service;
namespace Feedback.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackInfoService _feedbackInfoService;
        public FeedbackController(IFeedbackInfoService feedbackInfoService)
        {
            _feedbackInfoService = feedbackInfoService;
        }
        // GET: Feedback
        public ActionResult Index()
        {
            var data = _feedbackInfoService.GetAllFeedback();
            return View(data);
        }
    }
}