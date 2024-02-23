using ConsoleApp2;

BankAccount bankAccount = new BankAccount();
BankAccount bc2 = new BankAccount();
bankAccount.CreateAccount();
bc2.CreateAccount();
bankAccount.Print();
bankAccount.Deposit(100);
bankAccount.Print();

while (true)
{
    if (bankAccount.Withdrawal(int.Parse(Console.ReadLine()))){
        bankAccount.Print();
        break;
    } else
    {
        Console.WriteLine("Nu aveti banii in contul");
    }
}

while (true)
{
    if(bankAccount.TransferTo(bc2, int.Parse(Console.ReadLine())))
    {
        bankAccount.Print();
        bc2.Print();
        break;
    } else
    {
        Console.WriteLine("Nu aveti banii in contul");
    }
}