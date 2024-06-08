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

        public async Task<Jade> GetJadeById(int id)
        {
            return await _nzPureJadeShopDbContext.Jades.FindAsync(id);
        }

        public async Task<Jade> SaveJade(Jade jade)
        {
            await _nzPureJadeShopDbContext.Categories.FindAsync(jade.CategoryId);
            _nzPureJadeShopDbContext.Jades.Add(jade);
            await _nzPureJadeShopDbContext.SaveChangesAsync();
            return jade;
        }

        public async Task<Jade> UpdateJade(Jade jade)
        {
            var existingJade = await _nzPureJadeShopDbContext.Jades.AsNoTracking().FirstOrDefaultAsync(p => p.JadeId == jade.JadeId);
            if (existingJade == null)
            {
                throw new KeyNotFoundException($"Jade with ID {jade.JadeId} not found.");
            }

            _nzPureJadeShopDbContext.Entry(existingJade).State = EntityState.Detached;
            _nzPureJadeShopDbContext.Jades.Update(jade);
            await _nzPureJadeShopDbContext.SaveChangesAsync();
            return jade;
        }

        public async Task<Jade> DeleteJade(int jadeId)
        {
            var jade = await _nzPureJadeShopDbContext.Jades.FindAsync(jadeId);
            if (jade == null)
            {
                throw new KeyNotFoundException($"Jade with ID {jadeId} not found.");
            }

            _nzPureJadeShopDbContext.Jades.Remove(jade);
            await _nzPureJadeShopDbContext.SaveChangesAsync();
            return jade;
        }

        public IEnumerable<Jade> SearchJades(string searchQuery)
        {
            return _nzPureJadeShopDbContext.Jades.Where(j => j.Name.Contains(searchQuery));
        }
    }
}
