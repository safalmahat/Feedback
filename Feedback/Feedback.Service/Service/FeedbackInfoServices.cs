using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface IFeedbackInfoService
    {
        List<FeedbackInfo> GetAllFeedback();
    }
    public class FeedbackInfoService : IFeedbackInfoService
    {
        private IFeedbackRepo _feedbackRepo;
        public FeedbackInfoService(IFeedbackRepo feedbackRepo)
        {
            _feedbackRepo = feedbackRepo;
        }
        public List<FeedbackInfo> GetAllFeedback()
        {
            return _feedbackRepo.GetAllFeedback();
        }
    }
}
