using StorefrontApi.DataTransfer;
using StorefrontApi.Interfaces;
using StorefrontApi.PersistanceModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorefrontApi.LogicalModels
{
    [NotMapped]
    public class Developer : IReturnable<DeveloperDTO>, IPersistable<PersistantDeveloper>
    {
        public Guid Id { get; }
        public UserName UserName { get; }
        public string PasswordHash { get; }
        public string PasswordSalt { get; }
        public DisplayName DisplayName { get; }
        public Email Email { get; }
        public bool Active { get; }

        public DeveloperDTO ToDTO()
        {
            throw new NotImplementedException();
        }

        public PersistantDeveloper ToPersistant()
        {
            throw new NotImplementedException();
        }
    }
}
