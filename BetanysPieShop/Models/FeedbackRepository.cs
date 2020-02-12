using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetanysPieShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FeedbackRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _dbContext.Feedbacks.Add(feedback);
            _dbContext.SaveChanges();
        }
    }
}
