using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        

        public CategoryDal() 
        {
            _categories = new List<Category>
            {
                new Category{Id=1,Name="C++"},
                new Category{Id=2,Name="C#"},
                new Category{Id=3,Name="Java"}
            };

        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories) 
            {
                Console.WriteLine(category.Name);
            }
            return _categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category Updated!");
        }
    }
}
