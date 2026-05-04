internal class Program
{
    private static void Main(string[] args)
    {
        enterDetails();
        withdrowMoney();
    }
    static void enterDetails()
    {
        try
        {
            Console.WriteLine("please enter miles driven");
            double driven = double.Parse(Console.ReadLine());

            if (driven > 999 || driven < 0)
            {
                throw new IndexOutOfRangeException("No car can drive that many miles");
            }
            Console.WriteLine("please enter gallons used");
            double gallonsUsed = double.Parse(Console.ReadLine());
            double res = GallonsLeft(driven, gallonsUsed);
            Console.WriteLine($"mileage is {res} miles per gallon");
        }
        catch (FormatException)
        {
            Console.WriteLine("Idiot, you cannot enter that!");
            Console.WriteLine("Input string was not in a correct format.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.Write(ex.Message);
        }
    }
    static double GallonsLeft(double driven, double gallonsUsed)
    {
        double LEFT = driven / gallonsUsed;
        return LEFT;
    }
    static void withdrowMoney()
    {
        int balance = 10000;
        string IDnum;
        string creditCardNum;

        try
        {
            Console.WriteLine("Enter your ID number");
            IDnum = Console.ReadLine();
            
            Console.WriteLine("Enter your credit card number number");
            creditCardNum = Console.ReadLine();

            int IDcheck = int.Parse(IDnum);
            long creditcheck = long.Parse(creditCardNum);

            if (IDnum.Length > 9 || creditCardNum.Length > 16)
            {
                throw new OverflowException("input the credit/ID is too long");
            }
            if (IDnum.Length < 9 || creditCardNum.Length < 16)
            {
                throw new OverflowException("input the credit/ID is too sort");
            }
            Console.WriteLine("How mach do you want to withdrow");
            int withDrow = int.Parse(Console.ReadLine());

            if (withDrow > balance)
            {
                throw new FormatException("there is not enough cash in the balance");
            }
            balance -= withDrow;
            Console.WriteLine($"Your corrent balance is {balance}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}