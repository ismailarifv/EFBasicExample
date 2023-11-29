using EFBasicExample.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity
{
    internal class CategoryCrud : ICrud<Category>
    {
        DataContext db = new DataContext();
        public bool Add(Category entity)
        {
            if (entity != null)
            {
                entity.IsStatus = true;
                
                db.Category.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public bool Delete(int id)
        {
            var category = db.Category.Find(id);
            if (category != null)
            {
                //category.IsStatus = true;
                db.Category.Remove(category);
                db.SaveChanges();
                return true;
           }
            return false;
        }

        public Category Get(int id)
        {
            var category = db.Category.Find(id);
            if (category != null && !category.IsDelete)
            {
                return category;
            }
            return null;
        }

        public List<Category> GetList()
        {
            return db.Category.Where(x=>x.IsDelete==false).ToList();
        }

        public bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
