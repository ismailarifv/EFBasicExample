using EFBasicExample.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity
{
    internal class ProductCrud : ICrud<Product>
    {
        DataContext db = new DataContext();
        public bool Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
