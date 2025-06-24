using Lab4;
using System.ComponentModel;

//1.Write a program using method overloading by changing datatype of arguments to perform addition of two integer numbers and two float numbers.
Overloading o = new Overloading();
//Console.WriteLine("Add = "+o.Add(2, 3));
//Console.WriteLine("Float = " + o.Add(2.5f, 3.5f));

//2.Write a program using method overloading by changing number of arguments to calculate area of square and rectangle.
//Console.WriteLine(o.Area(5,6));

//3.Create a class named RBI with calculateInterest() method. Create another classes HDFC, SBI, ICICI which overrides calculateInterest() method
//RBI b;
//Console.WriteLine("Enter 1 for HDFC, 2 for SBI, 3 for ICICI");
//int choice = Convert.ToInt32(Console.ReadLine());
//switch (choice)
//{
//    case 1:
//        b = new HDFC();
//        Console.WriteLine("HDFC Bank Interest Calculation: "+b.CalculateInterest(1000,5,2));
//        break;
//    case 2:
//        b = new SBI();
//        Console.WriteLine("SBI Bank Interest Calculation: "+b.CalculateInterest(1000, 5, 2));
//        break;
//    case 3:
//        b = new ICICI();
//        Console.WriteLine("ICICI Bank Interest Calculation: "+b.CalculateInterest(1000, 5, 2));
//        break;
//}


//4.Create a class Hospital with HospitalDetails() method.Create another classes Apollo, Wockhardt, Gokul_Superspeciality which overrides HospitalDetails() method.
//Hospital h;
//h = new Apollo();
//h.HospitalDetails();

//h = new Wockhardt();
//h.HospitalDetails();

//h = new Gokul_Superspeciality();
//h.HospitalDetails();

//5.Write a programs to Find Area of Square, Rectangle and Circle using Method Overloading
//Circle c = new Circle();
//Console.WriteLine("Circle Area = " + c.Area(6.2));
//Console.WriteLine("Square Area = " + c.Area(5));
//Console.WriteLine("Rectangle Area = " + c.Area(5, 6));

//6.Create a BankAccount class having constructor accepting initialBalance and accountHolderName.
//Also create Deposite() and withdraw() overloaded methods by which user can deposit/withdraw amount
//using different types of parameters(ex.cash, check).

BankAccount account = new BankAccount("John Doe", 1000);
account.Deposit(500); // Deposit cash
account.Deposit("Ch001",5000);
account.Withdraw(500);
account.Withdraw("Ch002", 1000);
