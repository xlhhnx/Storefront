namespace StorefrontApi.Interfaces
{
    interface IPersistant
    {
    }

    interface IPersistant<T> : IPersistant
    {
        T ToLogicalObject();
    }
}
