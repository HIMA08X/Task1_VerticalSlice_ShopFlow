using System.ComponentModel.DataAnnotations;

namespace ShopFlow.Features.AddToCart
{
    public class AddToCartRequest
    {
        [Required]
        public int ProductId { get; set; }

        [Range(1,100)] 
        public int Quantity { get; set; }
    }
}
