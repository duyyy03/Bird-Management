using BirdRepository;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdService
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
