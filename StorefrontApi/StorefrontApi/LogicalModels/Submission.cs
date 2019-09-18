using StorefrontApi.DataTransfer;
using StorefrontApi.Interfaces;
using StorefrontApi.PersistanceModels;
using System;

namespace StorefrontApi.LogicalModels
{
    public class Submission : Game, IPersistable<PersistantSubmission>, IReturnable<SubmissionDTO>
    {
        public uint Approvals { get; set; }
        public uint Denials { get; set; }

        public SubmissionDTO ToDTO()
        {
            throw new NotImplementedException();
        }

        public PersistantSubmission ToPersistant()
        {
            throw new NotImplementedException();
        }
    }
}
