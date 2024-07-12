using Microsoft.AspNetCore.Mvc;
using ShoppingCart.UI.Services;
using ShoppingCart.UI.Models;
using Product.API.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShoppingCart.UI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductDto> list = new();
            var response = await _productService.GetAllProducts<ResponseDto>();
            if (response != null && response.IsSucess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
