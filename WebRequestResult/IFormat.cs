namespace WebRequestResult
{
    public interface IFormat
    {
        IFormat Next { get; set; }
        public string FormattedValue(Account account, Request request);
    }
}
