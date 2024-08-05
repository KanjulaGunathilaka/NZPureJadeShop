using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int JadeId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Jade Jade { get; set; } = default!;
        public Order Order { get; set; } = default!;
    }
}
