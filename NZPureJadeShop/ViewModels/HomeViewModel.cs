using NZPureJadeShop.Models;
using System.IO.Pipelines;

namespace NZPureJadeShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Jade> PopularJadeGifts { get; }

        public HomeViewModel(IEnumerable<Jade> popularJadeGifts)
        {
            PopularJadeGifts = popularJadeGifts;
        }
    }
}
