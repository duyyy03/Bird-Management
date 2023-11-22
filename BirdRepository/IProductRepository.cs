using BusinessObjects.Models;

namespace BirdRepository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);

        void AddProduct(Product product);
        void DeleteProduct(int id);
    }
}
