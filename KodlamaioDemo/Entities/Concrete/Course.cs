﻿using KodlamaioDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Entities.Concrete
{
    internal class Course:IEntity
    {
        public int Id { get; set; }
    }
}