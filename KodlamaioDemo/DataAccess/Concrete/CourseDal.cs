using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        public List<Course> _courseDal;

        public CourseDal() 
        {
            _courseDal = new List<Course>
            {
                new Course{Id=1,Name="CSharp Course",Price=750},
                new Course{Id=2,Name="C++ Course",Price=600},
                new Course{Id=3,Name="Java Course",Price=800}
            };
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Remove(course);
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courseDal) 
            {
                Console.WriteLine("Course Id = "+course.Id+" Course Name : "+course.Name+" Course Price = "+course.Price);
            }
            return _courseDal;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Course Updated!");
        }
    }
}
