using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;

namespace StorefrontApi.PersistanceModels
{
    public class PersistantDeveloper : IPersistant<Developer>
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public Developer ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
