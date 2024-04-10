using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public class MockJadeRepository : IJadeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Jade> AllJades =>
            new List<Jade>
            {
                new Jade {JadeId = 1, Name="New Zealand Greenstone Single Pikorua Twist", Price=288.00M, ShortDescription="Lorem Ipsum", LongDescription="Resembling the intertwining fronds of New Zealand's pikopiko fern, the Twist connects the spirit of friendship, family and of loved ones.\r\nA symbol of always being with one another regardless of where your journey takes you.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="wwwroot/Images/strawberrypie.jpg", InStock=true, IsPopularJadeGifts=false, ImageThumbnailUrl="Images/jade_home_01.jpg"},
                new Jade {JadeId  = 2, Name="New Zealand Pounamu Medium Toki Necklace", Price=128.00M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy ca", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="wwwroot/Images/cheesecake.jpg", InStock=true, IsPopularJadeGifts=false, ImageThumbnailUrl="Images/cheesecakesmall.jpg"},
                new Jade {JadeId  = 3, Name="New Zealand Pounamu Classic Small Toki", Price=118.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="wwwroot/Images/rhubarbpie.jpg", InStock=true, IsPopularJadeGifts=true, ImageThumbnailUrl="Images/rhubarbpiesmall.jpg"},
                new Jade {JadeId  = 4, Name="New Zealand Jade Brown Plaited Bracelet", Price=54.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="wwwroot/Images/pumpkinpie.jpg", InStock=true, IsPopularJadeGifts=true, ImageThumbnailUrl="Images/pumpkinpiesmall.jpg"}
            };

        public IEnumerable<Jade> PopularJadeGifts
        {
            get
            {
                return AllJades.Where(p => p.IsPopularJadeGifts);
            }
        }

        public Jade? GetJadeById(int jadeId) => AllJades.FirstOrDefault(p => p.JadeId == jadeId);

        public IEnumerable<Jade> SearchJades(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }

}
