namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount();
            
            Console.WriteLine("Hello, Welcom to Alex's Banking App!");
            Console.WriteLine("-------------------------------------");

            while (true)
            {
                Console.WriteLine("\n Please select an option");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2: Get balance");
                Console.WriteLine("3. Exit");
                Console.WriteLine("\n------------------------");

                int option;
                
                if(int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please Enter a valid optoin");
                    continue;
                }


                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you want to deposit:");
                        double amount=0;

                        if (double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid amount to deposit");
                            continue;
                        }
                        
                        account.Deposit(amount);
                        Console.WriteLine("Deposit succesful!");
                        break;
                    
                    case 2:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        break;
                    
                    case 3:
                        Console.WriteLine("Thank you for using Alex's banking app");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter a valid option.");
                        break;
                        
                }
            }
            











        }
    }
}
