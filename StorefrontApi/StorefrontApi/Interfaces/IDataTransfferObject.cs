namespace StorefrontApi.Interfaces
{
    interface IDataTransferObject
    {
    }

    interface IDataTransfferObject<T> : IDataTransferObject
    {
        T ToLogicalObject();
    }
}
