namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount();
//var currentBalance = account.GetBalance();
// Console.WriteLine(currentBalance);
// account.Deposit(220);
// currentBalance = account.GetBalance();
// Console.WriteLine(currentBalance);

            Console.WriteLine("Welcome to TrueStone Online Banking App!");
            Console.WriteLine("----------------------------------------");


            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Get balance");
                Console.WriteLine("3. Exit");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you would like to deposit:");
                        double amount;

                        if (double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input, Please enter a valid amount.");
                            continue;
                        }

                        account.Deposit(amount);
                        Console.WriteLine("Deposit succesful!");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you, Have a nice day!");
                        return;












                }
            }
        }
    }
}
