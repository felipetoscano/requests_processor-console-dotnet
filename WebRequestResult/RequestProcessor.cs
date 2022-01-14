using WebRequestResult.Formats;

namespace WebRequestResult
{
    public class RequestProcessor
    {
        public void Process(Account account, Request request)
        {
            var chain = new XmlFormat(
                new CsvFormat(
                    new PercentFormat(
                        new DefaultFormat())));

            var result = chain.FormattedValue(account, request);

            Console.WriteLine(result);
        }
    }
}
