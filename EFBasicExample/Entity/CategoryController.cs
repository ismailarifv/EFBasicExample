using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity
{
    internal class CategoryController
    {
       
        public static void CategoryList()
        {
            CategoryCrud categoryCrud = new CategoryCrud();
            if (categoryCrud.GetList().Count > 0)
            {
                foreach (var item in categoryCrud.GetList())
                {
                    Console.WriteLine($"Id:{item.Id}  Name: {item.Name} \t\t Status: {item.IsStatus}");
                }
            }
            else
            {
                Console.WriteLine("Kategori Listesi boş");
            }
        }
        public static void CategoryItemList()
        {
            CategoryCrud categoryCrud = new CategoryCrud();
            CategoryList();
            Console.Write("Category id seçin: ");
            var selectcategory = Convert.ToInt32(Console.ReadLine());
            var category = categoryCrud.Get(selectcategory);

            if (category != null)
            {
                Console.WriteLine($"Name: {category.Name}");
            }
            else
            {
                Console.WriteLine("Category bulunamadı");
            }
        }
        public static void CategoryAddItem()
        {
            CategoryCrud categoryCrud = new CategoryCrud();
            Console.Write("Kategori Adı: ");
            var writeCategoryName = Console.ReadLine();
            Console.Write("Kategori Açıklama: ");
            var writeCategoryDescription = Console.ReadLine();
            Category categoryAdd = new Category()
            {
                Name = writeCategoryName,
                Description = writeCategoryDescription
            };

            Console.WriteLine(categoryCrud.Add(categoryAdd) ? "Kategori Ekleme Başarılı" : "Ekleme Başarısız");
        }
        public static void CategoryUpdateItem()
        {
            CategoryCrud categoryCrud = new CategoryCrud();
            CategoryList();
            Console.Write("Yukarıdaki listeden istediğiniz id'li kategoriyi seçin:");
            int selectCategoryId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kategori Adı: ");
            var updateCategoryName = Console.ReadLine();
            Console.Write("Kategori Açıklama: ");
            var updateCategoryDescription = Console.ReadLine();

            var categoryUpdate = new Category()
            {
                Name = updateCategoryName,
                Description = updateCategoryDescription
            };
            if (categoryCrud.Update(categoryUpdate, selectCategoryId))
            {
                Console.WriteLine("Düzenleme başarılı");
            }
            else { Console.WriteLine("Düzenleme Başarısız"); }
        }
        public static void CategoryDeleteItem()
        {
            CategoryCrud categoryCrud = new CategoryCrud();
            CategoryList();
            Console.Write("Yukarıdaki kategorilerden silmek istediğnizin id'sini yazın");
            int selectDeleteCategoryId = Convert.ToInt32(Console.ReadLine());
            if (categoryCrud.Delete(selectDeleteCategoryId))
            {
                Console.WriteLine("Silme işlemi başarılı");
            }
            else
            {
                Console.WriteLine("Silme işlemi başarısız");
            }
        }
    }
}
