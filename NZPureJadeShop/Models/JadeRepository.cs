namespace NZPureJadeShop.Models
{
    public class JadeRepository : IJadeRepository
    {
        // Implement methods or properties defined in IJadeRepository
        public IEnumerable<Jade> AllJades => throw new NotImplementedException();

        public IEnumerable<Jade> PopularJadeGifts => throw new NotImplementedException();

        public Jade? GetJadeById(int jadeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jade> SearchJades(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
