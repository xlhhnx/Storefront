using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;

namespace StorefrontApi.DataTransfer
{
    public class DeveloperDTO : IDataTransferObject<Developer>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public Developer ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
