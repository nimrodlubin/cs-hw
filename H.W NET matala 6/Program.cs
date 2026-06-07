namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine(s);

            s.AddItem(new Item("milkey", "Milky is popular in Israel", 6));
            s.AddItem(new Item("cottage", "Basic dairy product", 4));

            Console.WriteLine(s);

            s.DeleteKnightFromDB(1);

            Console.WriteLine(s);
        }
    }
}
