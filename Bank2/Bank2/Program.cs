using System.Formats.Asn1;
using Bank2;

internal class Program
{
    private static void Main(string[] args)
    {
        Account a1 = new Account(123123123, 500);
        Account a2 = new VipAccount(1212, 43433.34, 5000);

        a1.Withdraw(510);
        a2.Withdraw(44000);

        Aricraft airP1 = new PassengerPlane("C-12", 2000, 112);
        Aricraft airP2 = new PassengerPlane("D-12", 500, 56);
        Aricraft F1 = new FighterJet("C-12", 2000, true);
        Aricraft F2 = new FighterJet("Q-1", 10000, true);

        Aricraft[] airPort = { airP1, airP2, F1, F2 };

        for (int i = 0; i < airPort.Length; i++)
        {
            airPort[i].PrintStatus();
            Console.WriteLine();
        }

        // F1.PrintStatus();
        // airP1.PrintStatus();

    }
}