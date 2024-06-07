using System.IO.Pipelines;
using NZPureJadeShop.Models.IRepository;

namespace NZPureJadeShop.Models
{
    public class MockJadeRepository : IJadeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Jade> AllJades =>
            new List<Jade>
            {
                new Jade {
                    JadeId = 1, 
                    Name="New Zealand Greenstone Single Pikorua Twist", 
                    Price=288.00M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Resembling the intertwining fronds of New Zealand's pikopiko fern, the Twist connects the spirit of friendship, family and of loved ones.\r\nA symbol of always being with one another regardless of where your journey takes you.", 
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    ImageUrl="wwwroot/Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg", 
                    InStock=true, 
                    IsPopularJadeGifts=false, 
                    ImageThumbnailUrl="Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg"},
                new Jade {
                    JadeId  = 2, 
                    Name="New Zealand Pounamu Medium Toki Necklace", 
                    Price=128.00M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Resembling the intertwining fronds of New Zealand's pikopiko fern, the Twist connects the spirit of friendship, family and of loved ones.\r\nA symbol of always being with one another regardless of where your journey takes you.", 
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    ImageUrl="wwwroot/Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg", 
                    InStock=true, 
                    IsPopularJadeGifts=false, 
                    ImageThumbnailUrl="Images/pikorua_GreenstoneSinglePikoruaTwist_small.jpg"},
                new Jade {
                    JadeId  = 3, 
                    Name="New Zealand Pounamu Classic Small Toki", 
                    Price=118.95M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Resembling the intertwining fronds of New Zealand's pikopiko fern, the Twist connects the spirit of friendship, family and of loved ones.\r\nA symbol of always being with one another regardless of where your journey takes you.", 
                    Category = _categoryRepository.AllCategories.ToList()[2],
                    ImageUrl="wwwroot/Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg", 
                    InStock=true, 
                    IsPopularJadeGifts=true, 
                    ImageThumbnailUrl="Images/pikorua_GreenstoneSinglePikoruaTwist_small.jpg"},
                new Jade {
                    JadeId  = 4, 
                    Name="New Zealand Jade Brown Plaited Bracelet", 
                    Price=54.95M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Resembling the intertwining fronds of New Zealand's pikopiko fern, the Twist connects the spirit of friendship, family and of loved ones.\r\nA symbol of always being with one another regardless of where your journey takes you.", 
                    Category = _categoryRepository.AllCategories.ToList()[3],
                    ImageUrl="wwwroot/Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg", 
                    InStock=true, 
                    IsPopularJadeGifts=true, 
                    ImageThumbnailUrl="Images/pikorua_GreenstoneSinglePikoruaTwist_small.jpg"}
            };

        public IEnumerable<Jade> PopularJadeGifts
        {
            get
            {
                return AllJades.Where(p => p.IsPopularJadeGifts);
            }
        }

        public Jade? GetJadeById(int jadeId) => AllJades.FirstOrDefault(p => p.JadeId == jadeId);

        public Task<Jade> SaveJade(Jade jade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jade> SearchJades(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }

}
