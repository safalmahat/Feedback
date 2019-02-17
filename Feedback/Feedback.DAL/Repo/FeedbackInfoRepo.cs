using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;

namespace Feedback.DAL.Repo
{
    public interface IFeedbackRepo
    {
        List<FeedbackInfo> GetAllFeedback();

    }
    public class FeedbackInfoRepo : IFeedbackRepo 
    {
        public List<FeedbackInfo> GetAllFeedback()
        {
            using (FeedBackEntities _entites = new FeedBackEntities())
            {
                return _entites.FeedbackInfoes.ToList();
            }
        }
    }
}
