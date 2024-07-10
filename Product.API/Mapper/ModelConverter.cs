using Microsoft.AspNetCore.Mvc.ModelBinding;
using Product.API.DTO;

namespace Product.API.Mapper
{
    public static class ModelConverter
    {
        public static Product.API.Entities.Product DtoToModel(ProductDto model)
        {
            return new Product.API.Entities.Product
            {
                Id = model.Id,
                Title = model.Title,
                Price = model.Price,
                Description = model.Description,
                CategoryId = model.CategoryId,
                ImageUrl = model.ImageUrl
            };
        }
        public static ProductDto ModelToDto(Product.API.Entities.Product model)
        {
            return new ProductDto
            {
                Id = model.Id,
                Title = model.Title,
                Price = model.Price,
                Description = model.Description,
                CategoryId = model.CategoryId,
                ImageUrl = model.ImageUrl
            };
        }
    }
}
