namespace StorefrontApi.LogicalModels
{
    public class DisplayName
    {
        public string Value { get; }

        public DisplayName(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(DisplayName displayName) => displayName.Value;
    }
}
