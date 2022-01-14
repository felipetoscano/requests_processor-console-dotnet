namespace WebRequestResult.Formats
{
    public class XmlFormat : IFormat
    {
        public IFormat Next { get; set; }

        public XmlFormat(IFormat next)
        {
            Next = next;
        }

        public string FormattedValue(Account account, Request request)
        {
            if (request.Format == Format.XML)
            {
                return $"<account><ownerName>{account.OwnerName}</ownerName><balance>{account.Balance}</balance></account>";
            }
            else
            {
                return Next.FormattedValue(account, request);
            }
        }
    }
}
