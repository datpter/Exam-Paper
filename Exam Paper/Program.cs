// See https://aka.ms/new-console-template for more information
using Exam_Paper.Controller;
using Exam_Paper.Data;
using Exam_Paper.Model;
using System.Diagnostics;


DataContext context = new DataContext();
ProductController productController = new ProductController(context);
while (true)
{
    Console.WriteLine("1. Add product:");
    Console.WriteLine("2. Delete product:");
    Console.WriteLine("3. Get all Product:");
    Console.WriteLine("4. Update Product");
    Console.WriteLine("5. Tim Kiem");
    Console.WriteLine("6. Exit");
    int chon = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Moi ban nhap");
    if (chon == 1)
    {
        Console.WriteLine("Enter product name:");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter price :");
        int price = Convert.ToInt32(Console.ReadLine());
        Product product = new Product
        {
            ProductName= productName,
            Price= price
        };
        productController.Add(product);


    }else if (chon == 2)
    {
        productController.DeleteStudent();
    }else if (chon == 3)
    {
        productController.GetALL();
    }else if(chon==4){
        productController.UpdateStudent();

    }else if(chon == 5)
    {
        productController.TimKiem();
    }else if (chon==6)
    {
        return;
    }
   

}
//Console.WriteLine("Enter product name :");
//string productName = Console.ReadLine();
//Console.WriteLine("Enter price :");
//int price = Convert.ToInt32(Console.ReadLine());
//Product product = new Product { ProductName = productName,
//    Price = price 
//};
//productController.Add(product);




