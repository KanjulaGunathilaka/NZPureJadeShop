using System.IO.Pipelines;

namespace NZPureJadeShop.Models.IRepository
{
    public interface IJadeRepository
    {
        IEnumerable<Jade> AllJades { get; }

        IEnumerable<Jade> PopularJadeGifts { get; }

        Task<Jade> GetJadeById(int id);

        IEnumerable<Jade> SearchJades(string searchQuery);

        Task<Jade> SaveJade(Jade jade);

        Task<Jade> UpdateJade(Jade jade);

        Task<Jade> DeleteJade(int jadeId);
    }
}
