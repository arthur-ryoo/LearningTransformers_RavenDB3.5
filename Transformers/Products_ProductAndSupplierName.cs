using LearningTransformers.Models;
using Raven.Client.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTransformers.Transformers
{
    public class Products_ProductAndSupplierName : AbstractTransformerCreationTask<Product>
    {
        public class Result
        {
            public string ProductName { get; set; }
            public string SupplierName { get; set; }
        }

        public Products_ProductAndSupplierName()
        {
            TransformResults = products =>
                from product in products
                let category = LoadDocument<Supplier>(product.Supplier)
                select new
                {
                    ProductName = product.Name,
                    SupplierName = category.Name
                };
        }
    }
}
