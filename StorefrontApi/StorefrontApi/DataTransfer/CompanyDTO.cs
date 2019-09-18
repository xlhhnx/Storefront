using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;
using System.Collections.Generic;

namespace StorefrontApi.DataTransfer
{
    public class CompanyDTO : IDataTransferObject<Company>
    {
        public string Id { get; }
        public string Name { get; }
        public IEnumerable<DeveloperDTO> Administrators { get; }

        public Company ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
