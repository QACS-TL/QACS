namespace BankingLibrary
{
    public class Account
    {
        public string Name { get; set; }
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set {
                if (value.Length != 8) {
                    throw new ArgumentException("Account number must be 8 chars.");
                }
                accountNumber = value; 
            }
        }
        private decimal balance;
        public decimal Balance
        {
            get => balance;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                balance = value;
            }
        }

        public decimal Credit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must not be negative!");
            }
            Balance += amount;
            return Balance;
        }

        public decimal Debit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must not be negative!");
            }
            if (Balance - amount >= 0)
            {
                Balance += amount;
            }
            return Balance;
        }   
        
        override   
    }
}
