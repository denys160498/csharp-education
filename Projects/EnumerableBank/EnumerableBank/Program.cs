using System;
using BankLibrary;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<Account> bank = new Bank<Account>("UnitBank");
            bool alive = true;

            while (alive)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen; // выводим список команд зеленым цветом
                Console.WriteLine("1. Open Account \t 2. Withdraw money  \t 3. Top up account");
                Console.WriteLine("4. Close Account \t 5. Display accounts \t 6. Skip day \t 7.Exit");
                Console.WriteLine("Enter your choice:");
                Console.ForegroundColor = color;

                try
                {
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            OpenAccount(bank);
                            break;
                        case 2:
                            Withdraw(bank);
                            break;
                        case 3:
                            Put(bank);
                            break;
                        case 4:
                            CloseAccount(bank);
                            break;
                        case 5:
                            ShowAllAccounts(bank);
                            break;
                        case 6:
                            break;
                        case 7:
                            alive = false;
                            continue;
                    }
                    bank.CalculatePercentage();
                }
                catch (Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }

        }

        public static void OpenAccount(Bank<Account> bank)
        {
            Console.WriteLine("Type sum for account creation: ");

            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Choose a type of an account: 1. Demand 2.Deposit");
            AccountType accountType;

            int type = Convert.ToInt32(Console.ReadLine());

            if (type == 2)
            {
                accountType = AccountType.Deposit;
            }
            else
            {
                accountType = AccountType.Ordinary;
            }

            bank.Open(accountType,
                sum,
                AddSumHandler,
                WithdrawSumHandler,
                (o, e) => Console.WriteLine(e.Message),
                CloseAccountHandler,
                OpenAccountHandler);

        }

        private static void Withdraw(Bank<Account> bank)
        {
            Console.WriteLine("Enter sum to withdraw:");

            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Account id:");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.Withdraw(sum, id);
        }

        private static void Put(Bank<Account> bank)
        {
            Console.WriteLine("Enter sum to top up by:");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Account id:");
            int id = Convert.ToInt32(Console.ReadLine());
            bank.Put(sum, id);
        }

        private static void CloseAccount(Bank<Account> bank)
        {
            Console.WriteLine("Enter account Id which has to be closed:");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.Close(id);
        }

        private static void ShowAllAccounts(Bank<Account> bank)
        {
            foreach (var acc in bank)
            {
                Console.WriteLine($"Account with id {(acc as Account).Id} contains {(acc as Account).Sum} money \n");
            }
        }

        private static void OpenAccountHandler(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private static void AddSumHandler(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private static void WithdrawSumHandler(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
            if (e.Sum > 0)
                Console.WriteLine("Идем тратить деньги");
        }

        private static void CloseAccountHandler(object sender, AccountEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
