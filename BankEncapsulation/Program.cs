namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDep = double.Parse(Console.ReadLine());
            account.Deposit(amountToDep);
            
            Console.WriteLine($"Thank you, your balance is now {account.GetBalance()}");











        }
    }
}
