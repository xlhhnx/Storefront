using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorefrontApi.PersistanceModels
{
    [Table("Company")]
    public class PersistantCompany : IPersistant<Company>
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set;  }
        public IEnumerable<Developer> Administrators { get; set;  }

        public Company ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
