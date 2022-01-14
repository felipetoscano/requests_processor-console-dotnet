namespace WebRequestResult.Formats
{
    public class PercentFormat : IFormat
    {
        public IFormat Next { get; set; }

        public PercentFormat(IFormat next)
        {
            Next = next;
        }

        public string FormattedValue(Account account, Request request)
        {
            if (request.Format == Format.PERCENT)
            {
                return $"{account.OwnerName}%{account.Balance}";
            }
            else
            {
                return Next.FormattedValue(account, request);
            }
        }
    }
}
