namespace StorefrontApi.LogicalModels
{
    public class CompanyName
    {
        public string Value { get; }

        public CompanyName(string value) => Value = value;

        public override string ToString() => Value;

        public static implicit operator string(CompanyName companyName) => companyName.Value;
    }
}
