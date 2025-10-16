namespace Lab1_Task.ConsoleApp
{
  internal class Program
    {
        static void Main()
        {
            BankAccount acc1 = new BankAccount("PL123456", "Alicja Zielonewzgórze", 1000m, "PLN", true, "Bank A");
            BankAccount acc2 = new BankAccount("PL654321" ,"Bob Marley", 500m, "PLN", true, "Bank B");
            BankAccount acc3 = new BankAccount("PL111222", "Willy Wonka", 2000m, "PLN", true, "Bank C");

            acc1.Deposit(300);
            Console.WriteLine($"{acc1.Ownername} ma {acc1.Balance} {acc1.Currency} po wpłacie.");
            acc2.Withdraw(200);
            Console.WriteLine($"{acc2.Ownername} ma {acc2.Balance} {acc2.Currency} po wypłacie.");
            acc1.TransferTo(acc1, 500);
            Console.WriteLine($"{acc1.Ownername} ma {acc1.Balance} {acc1.Currency}, a {acc3.Ownername} ma {acc3.Balance} {acc3.Currency} po przelewie.");
            acc3.CloseAccount();
            Console.WriteLine($"Czy konto {acc3.AccountNumber} jest aktywne? {acc3.IsActive}");
        }
        }
        }
