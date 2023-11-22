using BusinessObjects.Models;

namespace BirdService
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
        void DeleteProduct(int id);
    }
}
