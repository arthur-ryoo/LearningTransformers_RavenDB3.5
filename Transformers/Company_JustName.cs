using LearningTransformers.Models;
using Raven.Client.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTransformers.Transformers
{
    public class Company_JustName : AbstractTransformerCreationTask<Company>
    {
        public Company_JustName()
        {
            TransformResults = companies =>
                from company in companies
                select new { company.Name };
        }
    }
}
