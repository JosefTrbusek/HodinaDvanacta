namespace HodinaDvanacta
{
    internal class Account
    {
        public string AccountNumber { get; private set; }
        public string OwnerName { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string accountNumber, string ownerName)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Castka nemuze být záporná", nameof(amount));
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Castka nemuze být záporná", nameof(amount));
            }
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Castka prekracuje zustatek");
            }            
            Balance -= amount;            
        }
    }
}
