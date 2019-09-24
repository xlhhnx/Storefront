using StorefrontApi.DataTransfer;
using StorefrontApi.Interfaces;
using StorefrontApi.PersistanceModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorefrontApi.LogicalModels
{
    [NotMapped]
    public class User : IReturnable<UserDTO>, IPersistable<PersistantUser>
    {
        public Guid Id { get; }
        public UserName UserName { get; }
        public string PasswordHash { get; }
        public string PasswordSalt { get; }
        public DisplayName DisplayName { get; }
        public Email Email { get; }
        public bool Active { get; }

        public UserDTO ToDTO()
        {
            throw new NotImplementedException();
        }

        public PersistantUser ToPersistant()
        {
            throw new NotImplementedException();
        }
    }
}
