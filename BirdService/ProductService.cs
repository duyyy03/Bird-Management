using BirdRepository;
using BusinessObjects.Models;

namespace BirdService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productrepository;
        public ProductService() {
            _productrepository = new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            _productrepository.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productrepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productrepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productrepository.GetProductById(id);
        }

        public void UpdateProduct(Product product)
        {
            _productrepository.UpdateProduct(product);
        }
    }
}
