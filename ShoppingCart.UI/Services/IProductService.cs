namespace ShoppingCart.UI.Services
{
    public interface IProductService
    {
        private IProductService _productService;
        Task<T> GetAllProducts<T>();
        
    }
}
