﻿using Microsoft.EntityFrameworkCore;
using Product.API.Data;
using Product.API.DTO;
using Product.API.Mapper;

namespace Product.API.Services.implementations
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }

        public async  Task<ProductDto> CreateUpdateProductAsync(ProductDto productDto)
        {
            var product = ModelConverter.DtoToModel(productDto);
            if (product.Id > 0)
            {
                _context.Products.Update(product);
            }
            else
            {
                _context.Products.Add(product);
            }
            await _context.SaveChangesAsync();
            var dtoProduct=ModelConverter.ModelToDto(product);
            return dtoProduct;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product =await _context.Products.FirstOrDefaultAsync(p=> p.Id == id);
            if (product == null)
            {
                return false;
            }
            _context.Products.Remove(product);
            _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProduct()
        {
            var products =await _context.Products.Select(product=>
            ModelConverter.ModelToDto(product)).ToListAsync();
            return products;
        
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await _context.Products.Select(product=>
                ModelConverter.ModelToDto(product)).FirstOrDefaultAsync();
            return product;
        }
    }
}
