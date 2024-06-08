using NZPureJadeShop.Models;

namespace NZPureJadeShop.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<Category>? Categories { get; set; }
        public IEnumerable<Jade>? Jades { get; set; }

        public AdminViewModel() { }

        public AdminViewModel(IEnumerable<Category>? categories, IEnumerable<Jade>? jades)
        {
            Categories = categories;
            Jades = jades;
        }
    }
}
