using LearningTransformers.RavenDB;
using LearningTransformers.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTransformers.Controllers
{
    public class ProductsController
    {
        public static void GetProductAndSupplierName()
        {
            new Products_ProductAndSupplierName().Execute(DocumentStoreHolder.Store);
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                var product = session.Load<
                    Products_ProductAndSupplierName,
                    Products_ProductAndSupplierName.Result
                    >("products/1");

                Console.WriteLine($"{product.ProductName} from {product.SupplierName}");
            }
        }
    }
}
