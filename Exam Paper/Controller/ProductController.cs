using Exam_Paper.Data;
using Exam_Paper.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Paper.Controller
{
    public class ProductController
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }


        public void Add(Product product)
        {
            try
            {
                _context.Add(product);
                _context.SaveChanges();
                Console.WriteLine("Add Product successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Product failed: " + ex.Message);
            }
        }
     
        
        public void GetALL()
        {
            var products = _context.Products.ToList();
            foreach (var item in products)
            {
                Console.WriteLine($"Hello {item.ProductId} {item.ProductName} {item.Price}");
            }
        }
        public void DeleteStudent()
        {
            Console.WriteLine("Enter id ");
            int id = Convert.ToInt32(Console.ReadLine());
            var products = _context.Products.ToList();
            Product delete = (Product)_context.Products.Where(s => s.ProductId == id)
                                         .Single();
            if (delete != null)
            {
                try
                {
                    _context.Products.Remove(delete);
                    _context.SaveChanges();

                }
                catch (Exception e)
                { Console.WriteLine(e.Message); }
            }
        }

        public void UpdateStudent()
        {
            Console.WriteLine("Enter id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Product updateProduct = (Product)_context.Products.FirstOrDefault(s => s.ProductId == id)
                                         ;
        
            if (updateProduct is null)
            {

                Console.WriteLine("Khong tim thay id ");
            }
            else
            {
                Console.WriteLine($"{updateProduct.ProductName} {updateProduct.Price} ");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());

               
                updateProduct.ProductName = name;
                updateProduct.Price = price;
              
                try
                {
                    _context.Products.Update(updateProduct);
                    _context.SaveChanges();
                    Console.WriteLine("Update thanh cong ");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        public void TimKiem()
        {
            Console.WriteLine("Enter id ");
            int id = Convert.ToInt32(Console.ReadLine());
            var ket_qua_tra_ve = _context.Products.FirstOrDefault(s => s.ProductId == id);
            if (ket_qua_tra_ve is null)
            {

                Console.WriteLine("Khong tim thay !!!");
            }
            else { Console.WriteLine($"Hello {ket_qua_tra_ve.ProductName} {ket_qua_tra_ve.Price} "); }




        }


    }
}
