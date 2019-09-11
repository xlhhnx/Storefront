using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;

namespace StorefrontApi.DataTransfer
{
    public class UserDTO : IDataTransfferObject<User>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public User ToLogicalObject()
        {
            throw new System.NotImplementedException();
        }
    }
}
