using NZPureJadeShop.Models;
using System.IO.Pipelines;

namespace NZPureJadeShop.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<Category> Categories { get; }
        public IEnumerable<Jade> Jades { get; }

        public AdminViewModel(IEnumerable<Category> categories, IEnumerable<Jade> jades)
        {
            Categories = categories;
            Jades = jades;
        }
    }
}
