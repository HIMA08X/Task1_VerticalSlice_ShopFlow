using Microsoft.AspNetCore.Mvc;
namespace ShopFlow.Features.AddToCart
{
    [ApiController]
    [Route("[controller]")]
    public class AddToCartEndpoint:ControllerBase
    {
        [HttpPost]
        public ActionResult<AddToCartResponse> AddToCart(AddToCartRequest request)
        {
            var response = new AddToCartResponse
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                Message = $"Product {request.ProductId} added to cart with quantity {request.Quantity}."
            };
            return Ok(response);
        }

    }
}
