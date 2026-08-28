using System.ComponentModel.DataAnnotations;
namespace ShopFlow.Features.AddToCart
{
    public class AddToCartResponse
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
