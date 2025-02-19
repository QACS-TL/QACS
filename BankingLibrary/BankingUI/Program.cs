using BankingLibrary;

Account acc1 = new Account();
Account acc2 = new Account();
Account acc3 = new Account("Irma Person", "123456", 100.00m);
Account acc4 = new Account("A. N. Other", "888888", 40.00m);

acc1.Name = "Daisy Goodwin";
acc1.AccountNumber = "12345678";
acc1.Balance = 0.00m;

acc2.Name = "Sadia Saleem";
acc2.AccountNumber = "23232323";
acc2.Balance = 100.00m;

Console.WriteLine($"Account: {acc1.AccountNumber}, Name {acc1.Name}, Balance: {acc1.Balance:C}");
Console.WriteLine($"Account: {acc2.AccountNumber}, Name {acc2.Name}, Balance: {acc2.Balance:C}");

acc1.Credit(100.00m);
acc2.Debit(20.00M);

Console.WriteLine($"Account: {acc1.AccountNumber}, Name {acc1.Name}, Balance: {acc1.Balance:C}");
Console.WriteLine($"Account: {acc2.AccountNumber}, Name {acc2.Name}, Balance: {acc2.Balance:C}");

acc2.Debit(90.00M);
Console.WriteLine($"Account: {acc2.AccountNumber}, Name {acc2.Name}, Balance: {acc2.Balance:C}");

try
{
    Account acc3 = new Account();
    acc3.Name = "Tom Good";
    acc3.AccountNumber = "123456789";
    acc3.Balance = 0.00m;
} catch(Exception ex) { Console.WriteLine(ex.Message);  }

List<Account> accounts = new List<Account>();
accounts.Add(acc1);
accounts.Add(acc2);
accounts.Add(acc3);
accounts.Add(acc4);





