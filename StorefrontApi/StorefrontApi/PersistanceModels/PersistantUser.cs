using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorefrontApi.PersistanceModels
{
    [Table("User")]
    public class PersistantUser : IPersistant<User>
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public User ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
