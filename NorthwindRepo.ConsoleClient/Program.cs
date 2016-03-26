using NorthwindRepo.Business;
using NorthwindRepo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindRepo.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProduct ProdRepo = new ProductImpl();
            //var specificProduct = ProdRepo.Get(7);
            //Console.WriteLine("Product Name: " + specificProduct.ProductName);

            ICustomer CustRepo = new CustomerImpl();
            var specificCustomer = CustRepo.Get("Where CustomerID = @0", "LAUGB");
            Console.WriteLine("Customer: " + specificCustomer.CompanyName + " : " + specificCustomer.City);


            Console.ReadLine();
        }
    }
}
