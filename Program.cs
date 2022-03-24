using LearningTransformers.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTransformers
{
    class Program
    {
        static void Main(string[] args)
        {
            CompaniesController.GetCompany();
            Console.WriteLine("-----");
            CompaniesController.GetCompanyName();
            Console.WriteLine("-----");
            ProductsController.GetProductAndSupplierName();

            Console.WriteLine("Hit enter to exit");
            Console.ReadLine();
        }
    }
}
