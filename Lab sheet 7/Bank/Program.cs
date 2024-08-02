using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAccount
    {
        public int balance = 0;
        public abstract void deposit(int amount);
        public abstract void withdraw(int amount);

        public void displaybalance()
        {
            Console.WriteLine($"Account Balance: {balance}");
        }

    }
    public class SavingsAccount : BankAccount
    { 
        public override void deposit(int amount)
        {
            balance += amount;

        }
        public override void withdraw(int amount)
        {
            balance -= amount;
            
        }

    }
    public class CurrentAccount : BankAccount
    {
        public override void deposit(int amount)
        {
            balance += amount;
            

        }
        public override void withdraw(int amount)
        {
            balance -= amount;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount saccount = new SavingsAccount();
            CurrentAccount caccount = new CurrentAccount();

            saccount.deposit(2000);
            saccount.withdraw(1000);
            saccount.displaybalance();
            Console.ReadLine();
        }
        
    }
}
