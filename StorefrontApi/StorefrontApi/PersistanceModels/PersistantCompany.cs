using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;
using System.Collections.Generic;

namespace StorefrontApi.PersistanceModels
{
    public class PersistantCompany : IPersistant<Company>
    {
        public Guid Id { get; }
        public string Name { get; }
        public IEnumerable<Developer> Administrators { get; }

        public Company ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
