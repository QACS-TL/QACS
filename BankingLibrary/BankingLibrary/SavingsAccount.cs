using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class SavingsAccount: Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string name, string accountNumber, decimal balance, decimal interestRate) : base(name, accountNumber, balance)
        {
            this.InterestRate = interestRate;
        }

        public override decimal Debit(decimal amount)
        {
            if (Balance - amount < 0)
                base.Debit(amount);
            return Balance;
        }


        public decimal CalcInterest()
        {
            Balance += Balance * InterestRate;
            return Balance;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} for {Name} Account Number: {AccountNumber}'s balance is {Balance:c}. Interest rate is {InterestRate:c}";
        }
    }
}
