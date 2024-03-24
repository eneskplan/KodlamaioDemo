using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetAll();
    }
}
