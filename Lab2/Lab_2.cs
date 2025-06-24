using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    class Candidate
    {
        int Id;
        string Name;
        int Age;
        int Weight;
        double Height;

        public void GetCandidateDetails()
        {
            Console.Write("Enter ID: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"My name is {Name} with ID {Id} and Age {Age} and having Weight {Weight} and Height {Height} ft");
        }

    }

    class Staff
    {
        public string Name;
        public string Dept;
        public string Desig;
        public int Exp;
        public int Salary;

        public Staff(string name,string dept,string desig,int exp,int sal)
        {
            this.Name= name;
            this.Dept= dept;
            this.Desig= desig;
            this.Exp= exp;
            this.Salary= sal;
        }

        public void Display()
        {
            if(Desig.ToLower() == "hod")
            {
                Console.WriteLine($"Name: {Name} :::: Salary:{Salary}");
            }
        }
    }

    class Bank_Account
    {
        public int ac_no;
        public string email;
        public string name;
        public string ac_type;
        public int bal;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account No: ");
            ac_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Acc Type: ");
            ac_type = Console.ReadLine();
            Console.Write("Enter Balance: ");
            bal = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Acc No = {ac_no}");
            Console.WriteLine($"Email = {email}");
            Console.WriteLine($"Acc Type = {ac_type}");
            Console.WriteLine($"Bal = {bal}");
        }
    }

    class Student
    {
        public int enroll;
        public string name;
        public int sem;
        public double SPI;
        public double CPI;

        public Student(int e,string n,int s,double spi,double cpi)
        {
            this.enroll = e;
            this.name = n;
            this.sem = s;
            this.SPI = spi;
            this.CPI = cpi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Enroll = {enroll} {name} {sem} {SPI} {CPI}");
        }
    }

    class Recatangle
    {
        public int l;
        public int b;
        public Recatangle(int l, int b)
        {
            this.b = b;
            this.l = l;
            Area();
        }
        public void Area()
        {
            Console.WriteLine($"{l * b}");
        }

    }

    class Account_Details
    {
        public int p;
        public int r;
        public int n;

        public void getDetails()
        {
            Console.Write("Enter P: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter R: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Interest: Account_Details
    {
        public void Intere()
        {
            Console.WriteLine($"P = {p}");
            Console.WriteLine($"R = {r}");
            Console.WriteLine($"N = {n}");
            Console.WriteLine($"Int = {(p*r*n)/100}");
        }
    }

    class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;
        public Salary(double basic, double TA)
        {
            this.Basic = basic;
            this.TA = TA;
            this.DA = 1000;
            this.HRA = 1000;
        }
        public void Display()
        {
            double totalSalary = Basic + TA + DA + HRA;
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }

    class Distance
    {
        public int dist1;
        public int dist2;
        public int dist3;
        
        public Distance(int d1,int d2)
        {
            this.dist1= d1;
            this.dist2= d2;
        }

        public void Add()
        {
            dist3 = dist1 + dist2;
            Console.WriteLine($"{dist3}");
        }

    }

    class Furniture
    {
        public string material;
        public int price;
    }

    class Table : Furniture
    {
        public int height;
        public int surface_area;

        public void GetDet()
        {
            Console.Write("Enter Material: ");
            material = Console.ReadLine();
            Console.Write("Enter Price: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Surface Area: ");
            surface_area = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Price {price}");
            Console.WriteLine($"Material {material}");
            Console.WriteLine($"Height {height}");
            Console.WriteLine($"Surface Area {surface_area}");
        }
    }

    interface Gross
    {
        public void Gross_Sal();
    }
    class Salary1
    {
        public double HRA;
        public double DA;
        public double TA;

        public Salary1()
        {
            HRA = 0.1;
            DA = 0.05;
            TA = 0.1;
        }

        public void Display()
        {
            Console.WriteLine($"HRA = {HRA*100}%");
            Console.WriteLine($"TA = {TA * 100}%");
            Console.WriteLine($"DA = {DA * 100}%");
        }
    }
     
    class Employee:Salary1,Gross
    {
        public int basic_sal;

        public Employee(int s)
        {
            this.basic_sal= s;
        }
        public void Gross_Sal()
        {
            double s1 = basic_sal * HRA;
            double s2 = basic_sal * DA;
            double s3 = basic_sal * TA;

            Console.WriteLine($"HRA = {s1}");
            Console.WriteLine($"TA = {s3}");
            Console.WriteLine($"DA = {s2}");
            Console.WriteLine($"Gross Salary= {basic_sal-(s1+s2+s3)}");
        }
    }
}
