using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicExample.Entity
{
    internal class ProductController
    {
        public static void ProductList()
        {
            ProductCrud productCrud = new ProductCrud();
            if (productCrud.GetList().Count > 0)
            {
                foreach (var item in productCrud.GetList())
                {
                    Console.WriteLine($"Id:{item.Id}  Name: {item.Name} \t\t Price: {item.Price} \t\t Stock: {item.Stock}");
                }
            }
            else
            {
                Console.WriteLine("Ürün Listesi boş");
            }
        }
        public static void ProductItemList()
        {
            ProductCrud productCrud = new ProductCrud();
            ProductList();
            Console.Write("Ürün id seçin: ");
            var selectproduct = Convert.ToInt32(Console.ReadLine());
            var product = productCrud.Get(selectproduct);

            if (product != null)
            {
                Console.WriteLine($"Name: {product.Name} \t\t Price: {product.Price} \t\t Stock: {product.Stock}");
            }
            else
            {
                Console.WriteLine("Ürün Bulunamadı");
            }
        }
        public static void ProductAddItem()
        {
            ProductCrud productCrud = new ProductCrud();
            ProductList();
            Console.Write("Yukarıdaki listeden hangi kategoriye ürün ekleyeceksiniz id'sini yazın");
            var selectCategoryProductId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Adı: ");
            var writeProductName = Console.ReadLine();
            Console.Write("Ürün Açıklama: ");
            var writeProductDescription = Console.ReadLine();
            Console.Write("Ürün Stock: ");
            var writeProductStock = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Price: ");
            var writeProductPrice = Convert.ToDouble(Console.ReadLine());
            Product productAdd = new Product()
            {
                CategoryId = selectCategoryProductId,
                Name = writeProductName,
                Description = writeProductDescription,
                Stock = writeProductStock,
                Price = writeProductPrice
            };

            Console.WriteLine(productCrud.Add(productAdd) ? "Ürün Ekleme Başarılı" : "Ürün Ekleme Başarısız");
        }
        public static void ProductUpdateItem()
        {
            ProductCrud productCrud = new ProductCrud();
            ProductList();
            Console.Write("Yukarıdaki listeden istediğiniz id'li ürünü seçin:");
            int selectUrunId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Urun Adı: ");
            var updateUrunName = Console.ReadLine();
            Console.Write("Urun Açıklama: ");
            var updateUrunDescription = Console.ReadLine();
            Console.Write("Urun Stock: ");
            var updateUrunStock = Convert.ToInt32(Console.ReadLine());
            Console.Write("Urun Price: ");
            var updateUrunPrice = Convert.ToDouble(Console.ReadLine());

            var productUpdate = new Product()
            {
                Name = updateUrunName,
                Description = updateUrunDescription,
                Stock = updateUrunStock,
                Price = updateUrunPrice

            };
            if (productCrud.Update(productUpdate, selectUrunId))
            {
                Console.WriteLine("Düzenleme başarılı");
            }
            else { Console.WriteLine("Düzenleme Başarısız"); }
        }
        public static void ProductDeleteItem()
        {
            ProductCrud productCrud = new ProductCrud();
            ProductList();
            Console.Write("Yukarıdaki ürünlerden silmek istediğnizin id'sini yazın");
            int selectDeleteProductId = Convert.ToInt32(Console.ReadLine());
            if (productCrud.Delete(selectDeleteProductId))
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
