using NZPureJadeShop.Models.IRepository;

namespace NZPureJadeShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {
                        CategoryId = 1,
                        CategoryName = "Corded Necklaces",
                        Description = "We craft traditional New Zealand greenstone necklaces (pendants), working with the largest collection of New Zealand artists. Our pendants and necklaces are finished to the highest quality, each jade pendant lovingly carved by hand." },
                new Category {
                        CategoryId = 2,
                        CategoryName = "Pounamu Earrings",
                        Description = "Our New Zealand greenstone earrings are available in a wide variety of designs, from pounamu drop earrings with hook closures to 18ct gold and diamond studs." },
                new Category {
                        CategoryId = 3,
                        CategoryName = "Bangles & Bracelets",
                        Description = "Our bracelets are organic carved pieces of jewellery that should be worn around the wrist. Jade bangles come in multiple wrist sizes, corded bracelets can be adjusted in size, and our beaded bracelets run on an elastic band and can fit any wrist size." },
                new Category {
                        CategoryId = 4,
                        CategoryName = "Sculptures",
                        Description = "Our jade art is made from jade we've hand picked in countries around the world, including New Zealand. They all have exceptional colour that our jade artists enhance as their designs take shape." },
                new Category {
                        CategoryId = 5,
                        CategoryName = "Gold & Silver Jewellery",
                        Description = "Our jewellery combines jade with precious metals like silver and gold. We love working with some of New Zealand's most talented self taught jewellers to bring them to life. Each piece is hung on the chain pictured in its photograph, and you’ll receive the exact piece pictured when ordering." },
                new Category {
                        CategoryId = 6,
                        CategoryName = "New In",
                        Description = "Some of our artist's most eye catching pounamu pieces, straight off the carving bench. If you are looking for stand-out pieces, here are our newest picks. These pieces don't last long. " },
                new Category {
                        CategoryId = 7,
                        CategoryName = "Custom Carving",
                        Description = "Our custom made service allows you to work with talented New Zealand artists to bring your story to life in a truly unique and meaningful piece, carved locally by us and made bespoke for you or your loved one. Our Rotorua artists will work with you every step of the way to create your one-of-a-kind design." }
            };
    }
}
