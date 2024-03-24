using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Abstract
{
    public interface IGenericDal<T>where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        
    }
}
