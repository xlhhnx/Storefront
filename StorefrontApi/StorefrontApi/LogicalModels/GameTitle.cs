namespace StorefrontApi.LogicalModels
{
    public class GameTitle
    {
        public string Value { get; }

        public GameTitle(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(GameTitle gameTitle) => gameTitle.Value;
    }
}
