namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            myAccount.Deposit(2000.00);
            myAccount.GetWithDraw(1000.00);

            Console.WriteLine($"{myAccount.GetBalance()}");
            Console.WriteLine($"updated balance { myAccount.GetBalance()}");

        }
    }
}
