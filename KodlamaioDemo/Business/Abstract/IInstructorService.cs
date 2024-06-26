﻿using KodlamaioDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Abstract
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        List<Instructor> GetAll();
    }
}
