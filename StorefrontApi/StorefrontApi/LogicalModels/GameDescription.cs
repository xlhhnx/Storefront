namespace StorefrontApi.LogicalModels
{
    public class GameDescription
    {
        public string Value { get; }

        public GameDescription(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(GameDescription gameDescription) => gameDescription.Value;
    }
}
