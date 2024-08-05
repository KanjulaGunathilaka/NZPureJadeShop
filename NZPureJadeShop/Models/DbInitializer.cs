namespace NZPureJadeShop.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            NZPureJadeShopDbContext context =
                applicationBuilder.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<NZPureJadeShopDbContext>();
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Jades.Any())
            {
                context.AddRange
                (
                    new Jade
                    {
                        Name = "Greenstone Single Pikorua Twist",
                        Price = 288.95M,
                        ShortDescription = "Greenstone Single Pikorua Twist",
                        LongDescription = "Resembling the intertwining fronds of New Zealand's pikopiko fern, the Twist connects the spirit of friendship, family and of loved ones.A symbol of always being with one another regardless of where your journey takes you. The Twist is thought to represent two people's life path. Like the continuous shape of the pikorua, life for both individuals will continue despite many unexpected twists and turns, inevitably bringing them together again one day.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg",
                        InStock = true,
                        IsPopularJadeGifts = true,
                        ImageThumbnailUrl = "Images/cordednecklaces/pikorua_GreenstoneSinglePikoruaTwist.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Drop Earrings",
                        Price = 168.00M,
                        ShortDescription = "Pounamu Drop Earrings",
                        LongDescription = "Jade earrings are an understated way to bring the precious stone into your life. Whether studs or drop earrings, jade creates a tie to the land and one's heritage. New Zealand Pounamu earrings are among some of our most popular gifts. All our pendants come on an adjustable cord, unless otherwise stated. Our gold necklaces come with a complimentary gold-plated chain.",
                        Category = Categories["Pounamu Earrings"],
                        ImageUrl = "/Images/pounamuearrings/PounamuDropEarrings.jpg",
                        InStock = true,
                        IsPopularJadeGifts = true,
                        ImageThumbnailUrl = "Images/pounamuearrings/PounamuDropEarrings.jpg"
                    },
                    new Jade
                    {
                        Name = "Greenstone Bangle (65mm)",
                        Price = 1480.00M,
                        ShortDescription = "Greenstone Bangle (65mm)",
                        LongDescription = "Our greenstone bangles are statement piece made from high quality jade. Our pounamu bangles are created on the South Island's West Coast.\n\nSize: 64mm Internal Diameter x 81mm External Diameter",
                        Category = Categories["Bangles & Bracelets"],
                        ImageUrl = "/Images/banglesbracelets/GreenstoneBangle65mm.jpg",
                        InStock = true,
                        IsPopularJadeGifts = true,
                        ImageThumbnailUrl = "Images/banglesbracelets/GreenstoneBangle65mm.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Wahaika Sculpture with Base",
                        Price = 14998.00M,
                        ShortDescription = "Pounamu Wahaika Sculpture with Base",
                        LongDescription = "Stunning Wahaika carved from NZ Pounamu. The piece measures at 374mm x 75mm, with a resting height on the stand at 210mm. The metal stand measures at 300mm x 75mm.\n\nMountain Jade’s sculptures are a true work of art. Each piece is handcrafted from jade that has been carefully selected from countries around the world, including New Zealand.The exceptional color of the stone is enhanced by the skilled hands of our jade artists as they shape their designs. From contemporary carvings to traditional New Zealand designs, our sculptures represent the pinnacle of nature’s mysterious and implacable forces.",
                        Category = Categories["Sculptures"],
                        ImageUrl = "/Images/sculptures/PounamuWahaikaSculpturewithBase.jpg",
                        InStock = true,
                        IsPopularJadeGifts = true,
                        ImageThumbnailUrl = "Images/sculptures/PounamuWahaikaSculpturewithBase.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Silver Disc Necklace",
                        Price = 228.00M,
                        ShortDescription = "Pounamu Silver Disc Necklace",
                        LongDescription = "Size: 10mm x 10mm.\n\nHand hammered silver sets the beautiful rich green jade stone with this pendant. This style of design is a popular option which tends to get snapped quickly.\n\nWe work with some of New Zealand's most talented independent jewellers to bring together one of the country's finest collections of premium quality contemporary greenstone jewellery. ",
                        Category = Categories["Gold & Silver Jewellery"],
                        ImageUrl = "/Images/goldsilverjewellery/PounamuSilverDiscNecklace.jpg",
                        InStock = true,
                        IsPopularJadeGifts = true,
                        ImageThumbnailUrl = "Images/goldsilverjewellery/PounamuSilverDiscNecklace.jpg"
                    },
                    new Jade
                    {
                        Name = "New Zealand Pounamu Fern on Gold Bale",
                        Price = 148.00M,
                        ShortDescription = "New Zealand Pounamu Fern on Gold Bale",
                        LongDescription = "Size: 43mm x 17mm\n\nAll our pendants come on an adjustable cord, unless otherwise stated. Our gold necklaces come with a complimentary gold-plated chain.\n\nWe work with some of New Zealand's most talented independent jewellers to bring together one of the country's finest collections of premium quality contemporary greenstone jewellery. ",
                        Category = Categories["New In"],
                        ImageUrl = "/Images/newin/NewZealandPounamuFernonGoldBale.jpg",
                        InStock = true,
                        IsPopularJadeGifts = true,
                        ImageThumbnailUrl = "Images/newin/NewZealandPounamuFernonGoldBale.jpg"
                    },
                    new Jade
                    {
                        Name = "Tamaora Pounamu Manaia Sculpture",
                        Price = 19980.95M,
                        ShortDescription = "Tamaora Pounamu Manaia Sculpture",
                        LongDescription = "Mountain Jade’s sculptures are a true work of art. Each piece is handcrafted from jade that has been carefully selected from countries around the world, including New Zealand.\n\nThe exceptional color of the stone is enhanced by the skilled hands of our jade artists as they shape their designs. From contemporary carvings to traditional New Zealand designs, our sculptures represent the pinnacle of nature’s mysterious and implacable forces.",
                        Category = Categories["Custom Carving"],
                        ImageUrl = "/Images/customcarving/TamaoraPounamuManaiaSculpture.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/customcarving/TamaoraPounamuManaiaSculpture.jpg"
                    },
                    new Jade
                    {
                        Name = "New Zealand Jade Large Toki Pendant",
                        Price = 1298.95M,
                        ShortDescription = "New Zealand Jade Large Toki Pendant",
                        LongDescription = "Size: 152mm x 57mm\n\nOnce a tool wielded by Māori, when worn around the neck the Toki represents courage, and with courage comes strength and power.The Toki holds great significance in Māori culture as a powerful symbol of mana (prestige) and honour.\n\nTraditionally, the toki or adze was expertly lashed to carved wooden shafts and wielded as tools and ceremonial objects by Māori.\n\nToki are now worn around the neck as a symbol of strength and courage. This association links back to when toki blades crafted from pounamu were used as woodcutting tools due to pounamu's exceptional strength. It is said the Toki takes on the mauri or life force of the wearer, and this essence is passed from generation to generation.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/NewZealandJadeLargeTokiPendant.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/NewZealandJadeLargeTokiPendant.jpg"
                    },
                    new Jade
                    {
                        Name = "New Zealand Greenstone Same Stone Koru Necklace Set",
                        Price = 1028.95M,
                        ShortDescription = "New Zealand Greenstone Same Stone Koru Necklace Set",
                        LongDescription = "Size: 69mm x 30mm\n\nResembling the unfurling frond of the native New Zealand silver fern, the Koru connects us to new beginnings, hope for the future, and the good that will follow.\n\nA fundamental symbol in Māori art, the koru symbolises life and creation, with its fluid circular shape conveying the idea of everlastingness.\n\nThe koru is a beloved symbol throughout Aotearoa, seen painted on tipuna (meeting houses), waka (canoes), in traditional Tā moko (Māori tattooing) and on wood and greenstone carvings. Pounamu artists use the koru pattern in many different ways; often introducing it as surface-etching or detail into other forms and shapes. It is though to depict new beginnings, life and hope.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/NewZealandGreenstoneSameStoneKoruNecklaceSet.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/NewZealandGreenstoneSameStoneKoruNecklaceSet.jpg"
                    },
                    new Jade
                    {
                        Name = "New Zealand Closed Pounamu Koru",
                        Price = 748.95M,
                        ShortDescription = "New Zealand Closed Pounamu Koru",
                        LongDescription = "Size: 40mm x 40mm\n\nResembling the unfurling frond of the native New Zealand silver fern, the Koru connects us to new beginnings, hope for the future, and the good that will follow.\n\nA fundamental symbol in Māori art, the koru symbolises life and creation, with its fluid circular shape conveying the idea of everlastingness.\n\nThe koru is a beloved symbol throughout Aotearoa, seen painted on tipuna (meeting houses), waka (canoes), in traditional Tā moko (Māori tattooing) and on wood and greenstone carvings. Pounamu artists use the koru pattern in many different ways; often introducing it as surface-etching or detail into other forms and shapes. It is though to depict new beginnings, life and hope.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/NewZealandClosedPounamuKoru.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/NewZealandClosedPounamuKoru.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Barbed Hei Matau Pendant",
                        Price = 688.95M,
                        ShortDescription = "Pounamu Barbed Hei Matau Pendant",
                        LongDescription = "Size: 58mm x 45mm\n\nThe fish hook shape of the hei matau finds its origins in Māori legend, which holds that the North Island of New Zealand was once a huge fish that was caught by the great mariner, Māui.\n\nFor many, it is a way of signifying their connection to the water.\n\nSteeped in Māori legend, the Hei Matau connects us to the ocean. It is said to bring strength, prosperity and protection on your travels.\n\nThe fish hook denotes the importance of fishing to the Māori and their strong relationship with Tangaroa, the god of the sea. The ocean is deeply rooted in Māori worldview and culture and thought by many as the foundation of all life. Protected by the gods, it is a source of food and a place of ritual and spiritual connection, steeped in legend and stories telling of the creation of Aotearoa.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/PounamuBarbedHeiMatauPendant.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/PounamuBarbedHeiMatauPendant.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Manaia Necklace",
                        Price = 1498.95M,
                        ShortDescription = "Pounamu Manaia Necklace",
                        LongDescription = "Size: 101mm x 43mm\n\nThe Manaia is a messenger and spiritual kaitiaki (guardian) of the sky, earth and sea.A greatly respected mythological creature in Māori culture, it brings balance and protection to those you love most.\n\nWhat Manaia traditionally meant to Māori remains somewhat a mystery, but commonly it is considered that they are magical creatures and spiritual kaitiaki (guardians) of things worth protecting.\n\nBelieved to be a messenger that moves freely between the spirit realm and the human world, the manaia is a mythological creature, greatly respected in Māori culture and a predominant motif in wood and greenstone carving. Māori culture is rich in pūrākau (legends), and within these legends, mythological, supernatural, and magical creatures are featured prominently, often acting as kaitiaki (guardians) of people or places worth protecting.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/PounamuManaiaNecklace.jpg",
                        InStock = false,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/PounamuManaiaNecklace.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Dolphin Pendant",
                        Price = 668.95M,
                        ShortDescription = "Pounamu Dolphin Pendant",
                        LongDescription = "Size: 75mm x 34mm\n\nOur greenstone nature designs are a homage to the art, design, and culture of New Zealand. They are inspired by our great ocean, native birdlife and the New Zealand forest including Ferns, which are an iconic symbol of Aotearoa.\n\nAll our pendants come on an adjustable cord, unless otherwise stated. Our gold necklaces come with a complimentary gold-plated chain.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/PounamuDolphinPendant.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/PounamuDolphinPendant.jpg"
                    },
                    new Jade
                    {
                        Name = "Jade Heart with Koru and Notches",
                        Price = 528.95M,
                        ShortDescription = "Jade Heart with Koru and Notches",
                        LongDescription = "Size: 64mm x 59mm\n\nThe Heart is associated with unity, the expression of our true feelings and most loving connections. An everlasting symbol of unconditional love.Worn as a reminder of someone or to bring forth a fond memory, we associate this design with feelings of love.\n\nThe permanence of a heart carved into greenstone embodies your thoughts, feelings and emotions in the perfect expression of love.\n\nOne of the most renowned and recognised shapes is the heart - a universal symbol of love. To each individual, sharing the form of a heart may mean something unique, but embedded at its core are true feelings of love, unity and care.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/JadeHeartwithKoruandNotches.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/JadeHeartwithKoruandNotches.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Double Bodied Tiki Necklace",
                        Price = 2998.95M,
                        ShortDescription = "Pounamu Double Bodied Tiki Necklace",
                        LongDescription = "Size: 52mm x 110mm\n\nThe Hei Tiki is a taonga (treasure) in Māori culture.\n\nTraditionally passed from parent to child, it links the past, present and future, forming lasting connections with our tūpuna (ancestors) and bringing guardianship and protection.\n\nPassing down through generations of whanau (family), the mana (prestige) and korero (stories) of the Hei Tiki grow, forming lasting connections with tūpuna (ancestors) and bringing knowledge and protection.\n\nThought to represent the human form, Hei Tiki are a complex form, and one of the most challenging to shape by hand, with New Zealand pounamu typically being used for their creation. The form is deemed to be one of the highest achievements of early pounamu artistry and today's jade carvers take great care in protecting the culturally iconic figure in their work.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/PounamuDoubleBodiedTikiNecklace.jpg",
                        InStock = true,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/PounamuDoubleBodiedTikiNecklace.jpg"
                    },
                    new Jade
                    {
                        Name = "Pounamu Pendant with Guatemalan Jade Toggle Insert",
                        Price = 1498.95M,
                        ShortDescription = "Pounamu Pendant with Guatemalan Jade Toggle Insert",
                        LongDescription = "Size: 41mm x 28mm\n\nThe tear-drop shape of the Roimata holds a deep spiritual connection to the land, bringing energy and power.Māori culture emphasizes the interconnectedness of all things and tears are seen as a link between the physical and spiritual realms.\n\nThe Roimata's tear-drop shape embodies the idea of healing and resilience, reminding us of the strength within our tears.\n\nRoimata in Māori translates to tears, and when carved in pounamu, the tear-drop shape of the stone speaks to the depths of human emotion and the enduring connection between nature and spirituality. Just as natural world finds balance in its cycles, the Roimata, is thought to restore balance and well-being to those who wear it and is worn as a protective talisman, guiding individuals through life's ups and downs.",
                        Category = Categories["Corded Necklaces"],
                        ImageUrl = "/Images/cordednecklaces/PounamuPendantwithGuatemalanJadeToggleInsert.jpg",
                        InStock = false,
                        IsPopularJadeGifts = false,
                        ImageThumbnailUrl = "Images/cordednecklaces/PounamuPendantwithGuatemalanJadeToggleInsert.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Corded Necklaces",
                            Description = "We craft traditional New Zealand greenstone necklaces (pendants), working with the largest collection of New Zealand artists. Our pendants and necklaces are finished to the highest quality, each jade pendant lovingly carved by hand." },
                        new Category { CategoryName = "Pounamu Earrings",
                            Description = "Our New Zealand greenstone earrings are available in a wide variety of designs, from pounamu drop earrings with hook closures to 18ct gold and diamond studs." },
                        new Category { CategoryName = "Bangles & Bracelets",
                            Description = "Our bracelets are organic carved pieces of jewellery that should be worn around the wrist. Jade bangles come in multiple wrist sizes, corded bracelets can be adjusted in size, and our beaded bracelets run on an elastic band and can fit any wrist size." },
                        new Category { CategoryName = "Sculptures",
                            Description = "Our jade art is made from jade we've hand picked in countries around the world, including New Zealand. They all have exceptional colour that our jade artists enhance as their designs take shape." },
                        new Category { CategoryName = "Gold & Silver Jewellery",
                            Description = "Our jewellery combines jade with precious metals like silver and gold. We love working with some of New Zealand's most talented self taught jewellers to bring them to life. Each piece is hung on the chain pictured in its photograph, and you’ll receive the exact piece pictured when ordering." },
                        new Category { CategoryName = "New In",
                            Description = "Some of our artist's most eye catching pounamu pieces, straight off the carving bench. If you are looking for stand-out pieces, here are our newest picks. These pieces don't last long. " },
                        new Category { CategoryName = "Custom Carving",
                            Description = "Our custom made service allows you to work with talented New Zealand artists to bring your story to life in a truly unique and meaningful piece, carved locally by us and made bespoke for you or your loved one. Our Rotorua artists will work with you every step of the way to create your one-of-a-kind design." }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }

    }
}

