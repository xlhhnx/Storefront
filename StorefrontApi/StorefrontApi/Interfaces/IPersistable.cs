namespace StorefrontApi.Interfaces
{
    interface IPersistable<T> where T : IPersistant
    {
        T ToPersistant();
    }
}
