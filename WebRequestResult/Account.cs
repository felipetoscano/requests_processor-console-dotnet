namespace WebRequestResult
{
    public class Account
    {
        public string OwnerName { get; private set; }
        public double Balance { get; private set; }

        public Account(string ownerName, double balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
    }
}
