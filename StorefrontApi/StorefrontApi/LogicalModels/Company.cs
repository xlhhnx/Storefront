using StorefrontApi.DataTransfer;
using StorefrontApi.Interfaces;
using StorefrontApi.PersistanceModels;
using System;
using System.Collections.Generic;

namespace StorefrontApi.LogicalModels
{
    public class Company : IReturnable<CompanyDTO>, IPersistable<PersistantCompany>
    {
        public Guid Id { get; }
        public CompanyName Name { get;}
        public IEnumerable<Developer> Administrators { get; }

        public CompanyDTO ToDTO()
        {
            throw new NotImplementedException();
        }

        public PersistantCompany ToPersistant()
        {
            throw new NotImplementedException();
        }
    }
}
