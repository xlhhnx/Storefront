using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;

namespace StorefrontApi.DataTransfer
{
    public class GameDTO : IDataTransferObject<Game>
    {
        public string Id { get; set; }
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
