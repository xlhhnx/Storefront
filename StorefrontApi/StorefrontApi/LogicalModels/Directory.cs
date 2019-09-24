namespace StorefrontApi.LogicalModels
{
    public class Directory
    {
        public string Value { get; }

        public Directory(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(Directory directory) => directory.Value;
    }
}
