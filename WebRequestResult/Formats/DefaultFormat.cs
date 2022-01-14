namespace WebRequestResult.Formats
{
    public class DefaultFormat : IFormat
    {
        public IFormat Next { get; set; }

        public string FormattedValue(Account account, Request request)
        {
            return $"{account.OwnerName}, {account.Balance}";
        }
    }
}
