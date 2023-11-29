using EFBasicExample.Entity;
using System;

namespace EFBasicExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataContext db = new DataContext();

            /*Category category = new Category()
            {
                Name = "Bilgisayar",
                Description = "Bilgisayar Kategorisi",
                IsStatus = true,
            };
            Category category1 = new Category()
            {
                Name = "Telefon",
                Description="Telefon Kategorisi",
                IsStatus = true,
            };
            Category category2 = new Category()
            {
                Name = "Tablet",
                Description = "Tablet Kategorisi",
                IsStatus = true,
            };

            db.Category.Add(category1);
            db.Category.Add(category2);
            
            db.SaveChanges();
            */
            /*
              foreach (var item in db.Category.ToList()) 
              {
                  Console.WriteLine($"Name: {item.Name} \t Status: {(item.IsStatus?"Active":"Passive")}");

              }
              Console.WriteLine("-----------------------------");
              var category = db.Category.Find(2);
              //var category = db.Category.FirstOrDefault(x=>x.Name=="Tablet");
              if (category!=null)
              {
                  Console.WriteLine($"Name: {category.Name} \t Status: {(category.IsStatus ? "Active" : "Passive")}");
              }
              else
              {
                  Console.WriteLine("Kategori bulunamadı");
              }
              Console.WriteLine("------------------------------");
              var updateCategory=db.Category.Find(3);
              if (updateCategory!=null)
              {
                  updateCategory.Name = "Televizyon";
                  updateCategory.Description = "Televizyon Kategorisi";

                  db.SaveChanges();

              }
              
              */
            /*
            var deleteCategory = db.Category.Find(3);
            db.Category.Remove(deleteCategory);
            db.SaveChanges();
            Console.ReadLine();
            */

            ////////////////////////////////////////Burası interface filan filan
            ///

            // CategoryCrud categoryCrud = new CategoryCrud();
            /*
             //Category Ekleme
            Category category = new Category()
            {
                Name="Tablet",
                Description="Tablet Kategorisi"
            };

            Console.WriteLine(categoryCrud.Add(category)?"Kategori Ekleme Başarılı":"Ekleme Başarısız");
            */
            /*
             //Category Silme
            if (categoryCrud.Delete(4))
            {
                Console.WriteLine("Silme işlemi başarılı");
            }
            else
            {
                Console.WriteLine("Silme işlemi başarısız");
            }
            */
            //Category Getirme
            /*
            var category = categoryCrud.Get(2);

            if (category !=null ) 
            {
                Console.WriteLine($"Name: {category.Name}");
            }
            else
            {
                Console.WriteLine("Category bulunamadı");
            }

            */
            //Category Hepsini Getirme
            /*
            if (categoryCrud.GetList().Count > 0)
            {   
                foreach (var item in categoryCrud.GetList())
                {
                    Console.WriteLine($"Name: {item.Name} \t\t Status: {item.IsStatus}");
                }
            }
            else
            {
                Console.WriteLine("Kategori Listesi boş");
            }

            */
            /*
            var category = new Category()
            {
                Name = "Televizyon",
                Description = "Televizyon Kategori"
            };
            if (categoryCrud.Update(category,2))
            {
                Console.WriteLine("Düzenleme başarılı");
            }else { Console.WriteLine("Düzenleme Başarısız"); }
            Console.ReadLine();
            */
            //ProductCrud productCrud = new ProductCrud();
            bool status = true;
            bool status1 = true;
            bool status2 = true;
            while (status)
            {
                Console.WriteLine("--------Product Managment---------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Select Proccess : ");
                Console.WriteLine("Category Proccess (1)");
                Console.WriteLine("Product Proccess (2)");
                Console.WriteLine("Exit Program (0)");
                Console.WriteLine("Select ");
                int selectProccess = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (selectProccess)
                {
                    case 1:

                        while (status1)
                        {


                            Console.WriteLine("--------Category Proccess---------");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("Select Proccess : ");
                            Console.WriteLine("Category List (1):");
                            Console.WriteLine("Get Category (2):");
                            Console.WriteLine("Add Category (3)");
                            Console.WriteLine("Update Category (4)");
                            Console.WriteLine("Delete Category (5)");
                            Console.WriteLine("Back Category (0)");
                            Console.WriteLine("Select ");
                            int selectCategoryProccess = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (selectCategoryProccess)
                            {
                                case 1:
                                    CategoryController.CategoryList();
                                    break;
                                case 2:
                                    CategoryController.CategoryItemList();
                                    break;
                                case 3:

                                    CategoryController.CategoryAddItem();
                                    break;
                                case 4:
                                    CategoryController.CategoryUpdateItem();

                                    break;
                                case 5:
                                    CategoryController.CategoryDeleteItem();
                                    break;
                                case 0:
                                    status1 = false;
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;

                    case 2:
                        while (status2)
                        {
                            Console.WriteLine("--------Product Proccess---------");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Select Proccess : ");
                        Console.WriteLine("Product List (1):");
                        Console.WriteLine("Get Product (2):");
                        Console.WriteLine("Add Product (3)");
                        Console.WriteLine("Update Product (4)");
                        Console.WriteLine("Delete Product (5)");
                        Console.WriteLine("Back Product (0)");
                        Console.WriteLine("Select ");
                        int selectProductProccess = Convert.ToInt32(Console.ReadLine());
                            switch (selectProductProccess)
                            {
                                case 1:
                                    ProductController.ProductList();
                                    break;
                                case 2:
                                    ProductController.ProductItemList();
                                    break;
                                case 3:
                                    ProductController.ProductAddItem();
                                    break;
                                case 4:

                                    ProductController.ProductUpdateItem();
                                    break;
                                case 5:
                                    ProductController.ProductDeleteItem();
                                    break;
                                case 0:
                                    status2 = false; break;
                            }
                        }
                        break;
                    case 0: { status = false; break; }

                    default:
                        break;
                }

            }
            Console.ReadLine();

        }
    }
}
