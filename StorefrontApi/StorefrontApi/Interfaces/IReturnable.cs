namespace StorefrontApi.Interfaces
{
    interface IReturnable<T> where T : IDataTransferObject
    {
        T ToDTO();
    }
}
