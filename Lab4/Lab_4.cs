using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Overloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }


        public double Area(int s)
        {
            return s * s;
        }
        public double Area(int l,int b)
        {
            return l * b;
        }
    }

    class RBI
    {
        public virtual double CalculateInterest(int p,int r,int n)
        {
            return (p * r * n) / 100;
        }
    }
    class HDFC : RBI
    {
        public override double CalculateInterest(int p, int r, int n)
        {
            return (p * r * n) / 100;
        }
    }
    class SBI : RBI
    {
        public override double CalculateInterest(int p, int r, int n)
        {
            return (p * r * n) / 100;
        }
    }
    class ICICI : RBI
    {
        public override double CalculateInterest(int p, int r, int n)
        {
            Console.WriteLine("ICICI Bank Interest Calculation");
            return (p * r * n) / 100;
        }
    }

    class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: General Hospital");
        }
    }
    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: Apollo Hospital");
        }
    }
    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: Wockhardt Hospital");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: Gokul Superspeciality Hospital");
        }
    }

    class Circle
    {
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        public int Area(int s)
        {
            return s*s;
        }
        public int Area(int l, int b)
        {
            return l * b;
        }

    }

    class BankAccount
    {
        string accountHolderName;
        int initialBalance;
        public BankAccount(string name,int bal)
        {
            this.accountHolderName = name;
            this.initialBalance = bal;
        }

        public void Deposit(int amount)
        {
            initialBalance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {initialBalance}");
        }
        public void Deposit(string checkNumber, int amount)
        {
            initialBalance += amount;
            Console.WriteLine($"Check {checkNumber} deposited. Amount: {amount}. New balance: {initialBalance}");
        }

        public void Withdraw(int amount)
        {
            if (amount <= initialBalance)
            {
                initialBalance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance: {initialBalance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
        }
        public void Withdraw(string checkNumber, int amount)
        {
            if (amount <= initialBalance)
            {
                initialBalance -= amount;
                Console.WriteLine($"Check {checkNumber} withdrawal of {amount} processed. New balance: {initialBalance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
        }
    }
}
