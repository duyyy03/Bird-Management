using BirdDAO;
using BusinessObjects.Models;

namespace BirdRepository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product)
        => ProductDAO.Instance.AddProduct(product);

        public void DeleteProduct(int id)
        => ProductDAO.Instance.DeleteProduct(id);

        public List<Product> GetAllProducts()
        => ProductDAO.Instance.GetAllProducts();

        public Product GetProductById(int id)
        => ProductDAO.Instance.GetProductById(id);

        public void UpdateProduct(Product product)
        => ProductDAO.Instance.UpdateProduct(product);
    }
}
