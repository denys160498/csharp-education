using System;

namespace Delegates_And_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = { new PersonalAccount(100), new CorporativeAccount(150), new GovermentAccount(200)};

            for (int i = 0; i < 3; i++)
            {
                accounts[i].Notify += DisplayMessage;
                accounts[i].Notify += DisplayShortMessage;
            }

            for (int i = 0; i < 3; i++)
            {
                accounts[i].Put(300);
            }

            for (int i = 0; i < 3; i++)
            {
                accounts[i].Withdraw(450);
            }
            Console.Read();
        }

        private static void DisplayMessage(object sender, AccountHandlerEventArgs e)
        {
            string pretext = "";

            if (sender is PersonalAccount)
            {
                pretext = "Personal Account:";
            }
            else if (sender is CorporativeAccount)
            {
                pretext = "Corporative Account:";
            }
            else if (sender is GovermentAccount)
            {
                pretext = "Goverment Account:";
            }
            else
            {
                pretext = "Account:\n";
            }

            Console.WriteLine($"{pretext}\nTransaction amount: {e.Sum}\nBalance after transaction: {(sender as Account).Balance}\nMessage:{e.Message}");
        }

        private static void DisplayShortMessage(object sender, AccountHandlerEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Account message: {e.Message}\n\n");
            Console.ResetColor();
        }
    }
}
