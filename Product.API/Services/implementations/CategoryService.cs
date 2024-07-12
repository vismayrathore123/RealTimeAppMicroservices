using Microsoft.EntityFrameworkCore;
using Product.API.Data;
using Product.API.DTO;
using Product.API.Entities;
using Product.API.Mapper;

namespace Product.API.Services.implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ProductDbContext _context;

        public CategoryService(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryDto> CreateUpdateCategoryAsync(CategoryDto categoryDto)
        {
            var category = new Category
            {
                Id = categoryDto.Id,
                Title = categoryDto.Title
            };

            if (category.Id > 0)
            {
                _context.Categories.Update(category);
            }
            else
            {
                _context.Categories.Add(category);
            }

            await _context.SaveChangesAsync();

            return new CategoryDto
            {
                Id = category.Id,
                Title = category.Title
            };
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return false;
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Title = c.Title
            }).ToList();
        }

        public async Task<CategoryDto> GetCategoryById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            return new CategoryDto
            {
                Id = category.Id,
                Title = category.Title
            };
        }
    }
}
