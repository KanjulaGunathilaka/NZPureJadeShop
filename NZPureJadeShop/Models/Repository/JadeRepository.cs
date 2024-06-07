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

        public async Task<Jade> SaveJade(Jade jade)
        {

            await _nzPureJadeShopDbContext.Categories.FindAsync(jade.CategoryId);

            _nzPureJadeShopDbContext.Jades.Add(jade);


            await _nzPureJadeShopDbContext.SaveChangesAsync();

            return jade;
        }

        public IEnumerable<Jade> SearchJades(string searchQuery)
        {
            return _nzPureJadeShopDbContext.Jades.Where(j => j.Name.Contains(searchQuery));
        }
    }
}
