namespace StorefrontApi.LogicalModels
{
    public class UserName
    {
        public string Value { get; }

        public UserName(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(UserName userName) => userName.Value;
    }
}
