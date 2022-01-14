namespace WebRequestResult.Formats
{
    public class CsvFormat : IFormat
    {
        public IFormat Next { get; set; }

        public CsvFormat(IFormat next)
        {
            Next = next;
        }

        public string FormattedValue(Account account, Request request)
        {
            if (request.Format == Format.CSV)
            {
                return $"{account.OwnerName};{account.Balance}";
            }
            else
            {
                return Next.FormattedValue(account, request);
            }
        }
    }
}
