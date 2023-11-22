using BusinessObjects.Models;

namespace BirdDAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }
        public List<Category> GetCategories()
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
