using Microsoft.EntityFrameworkCore;
using NZPureJadeShop.Models.IRepository;

namespace NZPureJadeShop.Models.Repository
{
    public class JadeRepository : IJadeRepository
    {
        private readonly NZPureJadeShopDbContext _nzPureJadeShopDbContext;

        //Press Alt+Enter to generate constructor
        public JadeRepository(NZPureJadeShopDbContext nzPureJadeShopDbContext)
        {
            _nzPureJadeShopDbContext = nzPureJadeShopDbContext;
        }

        public IEnumerable<Jade> AllJades
        {
            get
            {
                return _nzPureJadeShopDbContext.Jades.Include(c => c.Category);
            }

        }

        public IEnumerable<Jade> PopularJadeGifts
        {
            get
            {
                return _nzPureJadeShopDbContext.Jades.Include(c => c.Category).Where(p => p.IsPopularJadeGifts);
            }
        }

        public Jade? GetJadeById(int jadeId)
        {
            return _nzPureJadeShopDbContext.Jades.FirstOrDefault(p => p.JadeId == jadeId);
        }

        public IEnumerable<Jade> SearchJades(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
