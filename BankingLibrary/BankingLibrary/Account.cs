namespace BankingLibrary
{
    public class Account
    {
        public Account() : this("Anon")
        {

        }

        public Account(string name) : this(name, accountNumber: "XXXXXXXX")
        {

        }

        public Account(string name, string accountNumber) : this(name, accountNumber, 0)
        {

        }

        public Account(string name, string accountNumber, decimal balance)
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        private List<Account> accounts = new List<Account>();

        public List<Account> Accounts
        {
            get { return accounts = new List<Account>(); }
            set { accounts = value; }
        }


        private string name = "Anonymous";

        public string Name
        {
            get { return name; }
            set
            {
                if (name.Length <= 1)
                {
                    return;
                }
                name = value;
            }
        }

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
        protected decimal balance = 0;
        public virtual decimal Balance
        {
            get { return balance; }
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

        public virtual decimal Debit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must not be negative!");
            }
            Balance -= amount;

            return Balance;
        }   
 
    }
}
