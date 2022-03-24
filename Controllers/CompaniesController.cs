using LearningTransformers.Models;
using LearningTransformers.RavenDB;
using LearningTransformers.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTransformers.Controllers
{
    public class CompaniesController
    {
        public static void GetCompany()
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                var company = session.Load<Company>("companies/89");
                Console.WriteLine(company.Name);
            }
        }

        public static void GetCompanyName()
        {
            new Company_JustName().Execute(DocumentStoreHolder.Store);
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                var company = session.Load<Company_JustName, Company>("companies/89");
                Console.WriteLine(company.Name);
            }
        }
    }
}
