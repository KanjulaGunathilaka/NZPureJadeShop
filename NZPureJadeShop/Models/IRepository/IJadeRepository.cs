using System.IO.Pipelines;

namespace NZPureJadeShop.Models.IRepository
{
    public interface IJadeRepository
    {
        IEnumerable<Jade> AllJades { get; }

        IEnumerable<Jade> PopularJadeGifts { get; }

        Jade? GetJadeById(int jadeId);

        IEnumerable<Jade> SearchJades(string searchQuery);

        Task<Jade> SaveJade(Jade jade);
    }
}
