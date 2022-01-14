namespace WebRequestResult
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new Account("Felipe", 10000);
            var request = new Request(Format.XML);

            var requestProcessor = new RequestProcessor();

            requestProcessor.Process(account, request);
        }
    }
}