using StorefrontApi.DataTransfer;
using StorefrontApi.Interfaces;
using StorefrontApi.PersistanceModels;
using System;

namespace StorefrontApi.LogicalModels
{
    public class Game : IPersistable<PersistantGame>, IReturnable<GameDTO>
    {
        public Guid Id { get; set; }
        public GameTitle Title { get; set; }
        public GameDescription ShortDescription { get; set; }
        public Directory StorePageDirectory { get; set; }
        public Directory GameFileDirectory { get; set; }

        public GameDTO ToDTO()
        {
            throw new NotImplementedException();
        }

        public PersistantGame ToPersistant()
        {
            throw new NotImplementedException();
        }
    }
}
