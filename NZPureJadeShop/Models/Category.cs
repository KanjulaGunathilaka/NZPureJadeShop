using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Jade>? Jades { get; set; }
    }
}
