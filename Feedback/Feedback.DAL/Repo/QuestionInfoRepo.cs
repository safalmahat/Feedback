using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Model;

namespace Feedback.DAL.Repo
{
    public interface IQuestionRepo
    {
        List<QuestionInfo> GetAllQuestion();
    }
    public class QuestionInfoRepo:IQuestionRepo
    {
        
        List<QuestionInfo> lst = new List<QuestionInfo>();

        public List<QuestionInfo> GetAllQuestion()
        {
            using (FeedBackEntities _entities = new FeedBackEntities())
            {
                lst = _entities.QuestionInfoes.ToList();
            }
            return lst;
        }
    }
}
