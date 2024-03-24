using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor {Id=1,FirstName="Engin",LastName="Demiroğ"},
                new Instructor {Id=2,FirstName="Halit Enes",LastName="Kalaycı"}
            };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine("Instructor Id = "+instructor.Id+"Instructor FirstName : "+instructor.FirstName+"Instructor LastName : "+instructor.LastName);
            }
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Instructor Updated!");
        }
    }
}
