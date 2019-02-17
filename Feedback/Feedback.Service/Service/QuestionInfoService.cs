using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedback.DAL.Repo;
using Feedback.DAL.Model;

namespace Feedback.Service.Service
{
    public interface IQuestionInfoService
    {
        List<QuestionInfo> GetAllQuestion();
    }
    public class QuestionInfoService:IQuestionInfoService
    {
        private IQuestionRepo _questionRepo;
        public QuestionInfoService(IQuestionRepo questioninfoservice)
        {
            _questionRepo = questioninfoservice;
        }
        
        public List<QuestionInfo> GetAllQuestion()
        {
            return _questionRepo.GetAllQuestion();
            
        }

    }
}
