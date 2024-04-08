
using NZPureJadeShop.Models;

namespace NZPureJadeShop.ViewModels
{
    public class JadeListViewModel
    {
        public IEnumerable<Jade> Jades { get; }
        public string? CurrentCategory { get; }

        public JadeListViewModel(IEnumerable<Jade> jades, string? currentCategory)
        {
            Jades = jades;
            CurrentCategory = currentCategory;
        }
    }
}

