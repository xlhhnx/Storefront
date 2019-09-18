namespace StorefrontApi.Interfaces
{
    interface IDataTransferObject
    {
    }

    interface IDataTransferObject<T> : IDataTransferObject
    {
        T ToLogicalObject();
    }
}
