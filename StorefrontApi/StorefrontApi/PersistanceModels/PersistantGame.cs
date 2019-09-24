using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;

namespace StorefrontApi.PersistanceModels
{
    public class PersistantGame : IPersistant<Game>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string StorePageDirectory { get; set; }
        public string GameFileDirectory { get; set; }

        public Game ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
