using BankingLibrary;

Account acc1 = new CurrentAccount("Daisy Goodwin", "12345678", 0.00m, 50.00m);
Account acc2 = new SavingsAccount("Sadia Saleem", "23232323", 100.00m, 0.10m);


//acc1.Name = "Daisy Goodwin";
//acc1.AccountNumber = "12345678";
//acc1.Balance = 0.00m;

//acc2.Name = "Sadia Saleem";
//acc2.AccountNumber = "23232323";
//acc2.Balance = 100.00m;

Console.WriteLine($"Account: {acc1.AccountNumber}, Name {acc1.Name}, Balance: {acc1.Balance:C}");
Console.WriteLine($"Account: {acc2.AccountNumber}, Name {acc2.Name}, Balance: {acc2.Balance:C}");

acc1.Credit(100.00m);
acc2.Debit(20.00M);

Console.WriteLine($"Account: {acc1.AccountNumber}, Name {acc1.Name}, Balance: {acc1.Balance:C}");
Console.WriteLine($"Account: {acc2.AccountNumber}, Name {acc2.Name}, Balance: {acc2.Balance:C}");

acc2.Debit(90.00M);
Console.WriteLine($"Account: {acc2.AccountNumber}, Name {acc2.Name}, Balance: {acc2.Balance:C}");

Account acc3 = new CurrentAccount("Irma Person", "34343434", 100.00m, 200.00m);
Account acc4 = new SavingsAccount("Belle a Trix", "56565656", 30.00m, 0.05m);

try
{
    Account acc5 = new Account();
    acc5.Name = "Tom Good";
    acc5.AccountNumber = "123456789";
    acc5.Balance = 0.00m;
} catch(Exception ex) { Console.WriteLine(ex.Message);  }

List<Account> accounts = new List<Account>();
accounts.Add(acc1);
accounts.Add(acc2);
accounts.Add(acc3);
accounts.Add(acc4);

// Apply Interest or determine Overdraft Limit
foreach (Account a in accounts)
{
    if (a is SavingsAccount)
    {
        Console.WriteLine($"{a.GetType().Name} Interest: {((SavingsAccount)a).CalcInterest()}");
    }
    CurrentAccount ca = a as CurrentAccount;
    if (ca != null)
        Console.WriteLine(($"{a.GetType().Name} Overdraft Limit: {ca.OverDraftLimit}"));
    Console.WriteLine($"{a.ToString()}");
}




