namespace StorefrontApi.LogicalModels
{
    public class Email
    {
        public string Value { get; }

        public Email(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(Email email) => email.Value;
    }
}
