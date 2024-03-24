using KodlamaioDemo.Business.Abstract;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _category;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _category = categoryDal;
        }
        public void Add(Category category)
        {
            _category.Add(category);
        }

        public void Delete(Category category)
        {
            _category.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _category.GetAll();
        }

        public void Update(Category category)
        {
            _category.Update(category);
        }
    }
}
