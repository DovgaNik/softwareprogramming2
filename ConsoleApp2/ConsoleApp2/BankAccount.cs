using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BankAccount
    {
        private string name;
        private int sold;

        public void CreateAccount()
        {
            Console.Write("Owner: "); name = Console.ReadLine();
            sold = 0;
        }

        public void Print()
        {
            Console.WriteLine($"{name} has {sold}RON");
        }

        public void Deposit(int amount)
        {
            sold += amount;
        }

        public bool Withdrawal(int amount)
        {
            if (sold > amount)
            {
                sold -= amount;
                return true;
            }
            else
                return false;
        }

        public bool TransferTo(BankAccount destination, int amount)
        {
            if (Withdrawal(amount))
            {
                destination.Deposit(amount);
                return true;
            }
            else
                return false;
        }
    }
}
