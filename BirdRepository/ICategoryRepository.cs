using BusinessObjects.Models;

namespace BirdRepository
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
