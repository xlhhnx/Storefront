using StorefrontApi.Interfaces;
using StorefrontApi.LogicalModels;
using System;

namespace StorefrontApi.DataTransfer
{
    public class SubmissionDTO : GameDTO, IDataTransferObject<Submission>
    {
        public uint Approvals { get; set; }
        public uint Denials { get; set; }

        public Submission ToLogicalObject()
        {
            throw new NotImplementedException();
        }
    }
}
