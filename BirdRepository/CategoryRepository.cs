using BirdDAO;
using BusinessObjects.Models;

namespace BirdRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
        => CategoryDAO.Instance.GetCategories();
    }
}
