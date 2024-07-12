using Microsoft.AspNetCore.Mvc;
using Product.API.DTO;
using Product.API.Services;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ResponseDto _response;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<CategoryDto> categoryDtos = await _categoryService.GetAllCategories();
                _response.Result = categoryDtos;
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
                CategoryDto categoryDto = await _categoryService.GetCategoryById(id);
                _response.Result = categoryDto;
            }
            catch (Exception ex)
            {
                _response.IsSucess = false;
                _response.Errors = new List<string> { ex.Message };
            }
            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] CategoryDto categoryDto)
        {
            try
            {
                CategoryDto model = await _categoryService.CreateUpdateCategoryAsync(categoryDto);
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
        public async Task<object> Put([FromBody] CategoryDto categoryDto)
        {
            try
            {
                CategoryDto model = await _categoryService.CreateUpdateCategoryAsync(categoryDto);
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
                bool isSuccess = await _categoryService.DeleteCategoryAsync(id);
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
