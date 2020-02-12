using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PieRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _dbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
