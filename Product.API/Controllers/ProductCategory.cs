using Microsoft.AspNetCore.Mvc;
using Product.API.DTO;
using Product.API.Services;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ResponseDto _response;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
            _response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _productService.GetAllProduct();
                _response.Result = productDtos;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Errors = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpGet("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDto productDto = await _productService.GetProductById(id);
                _response.Result = productDto;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Errors = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto model = await _productService.CreateUpdateProductAsync(productDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Errors = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto model = await _productService.CreateUpdateProductAsync(productDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Errors = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpDelete("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _productService.DeleteProductAsync(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Errors = new List<string> { ex.Message };
            }
            return _response;
        }
    }
}
