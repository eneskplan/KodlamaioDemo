using KodlamaioDemo.Business.Abstract;
using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorService _instructorService;
        public InstructorManager(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public void Add(Instructor instructor)
        {
            _instructorService.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorService.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorService.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructorService.Update(instructor);
        }
    }
}
