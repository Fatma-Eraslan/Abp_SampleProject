using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProductManagement.Categories
{
    public class Category : AuditedAggregateRoot<Guid> //Burada, Guid varlığın birincil anahtar (Kimlik) türüdür. 
    {
        public string Name { get; set; }
    }
}
