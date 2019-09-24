using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;

namespace StorefrontApi.PersistanceModels
{
    public class PersistantSubmission : PersistantGame, IPersistant<Submission>
    {
        public uint Approvals { get; set; }
        public uint Denials { get; set; }

        public Submission ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
