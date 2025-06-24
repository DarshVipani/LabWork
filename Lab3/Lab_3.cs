using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Lab_3
    //1 and 2
    {
        public void DivideByZero(int a, int b = 0)
        {
            try
            {
                int c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception = " + e);
            }
        }

        public void ArrayIndexOut()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 number: ");
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception = " + e);
            }
        }
    }


    public abstract class Sum
    {
        public abstract int SumofTwo(int a, int b);
        public abstract int SumofThree(int a, int b, int c);
    }

    class Calculate : Sum
    {
        public override int SumofTwo(int a, int b)
        {
            return a + b;
        }
        public override int SumofThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    interface Calculate_1
    {
        public void Addition(int a, int b);
        public void Subtraction(int a, int b);
    }
    class Result : Calculate_1
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition= " + (a + b));
        }

        public void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction= " + (a - b));
        }
    }


    public class StringCase
    {
        public void ViceVersa(String s)
        {
            String ans = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsLower(c))
                {
                    ans += char.ToUpper(c);
                }
                else
                {
                    ans += char.ToLower(c);
                }
            }
            Console.WriteLine("Converted String: " + ans);
        }
    }

    public interface Shape
    {
        public void Circle(double radius);
        public void Triangle(double baseLength, double height);
        public void Square(double sideLength);
    }
    public class Shape2 : Shape
    {
        public void Circle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }
        public void Triangle(double baseLength, double height)
        {
            double area = 0.5 * baseLength * height;
            Console.WriteLine("Area of Triangle: " + area);
        }
        public void Square(double sideLength)
        {
            double area = sideLength * sideLength;
            Console.WriteLine("Area of Square: " + area);
        }
    }

    public class EvenNoException
    {
        public void Add(int a)
        {
            try
            {
                if (a % 2 == 0)
                {
                    throw new Exception("Number is Even Not Valid!!!");
                }
                else
                {
                    Console.Write($"Good j kevai = {a}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


    public class Long
    {
        public void Word(String s)
        {
            string[] ch = s.Split(" ");
            string max = ch[0];

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i].Length > max.Length)
                {
                    max = ch[i];
                }
            }
            Console.WriteLine(max);
        }

        public void CharChange(char c)
        {
            if (char.IsLower(c))
            {
                Console.WriteLine("UpperCase = " + char.ToUpper(c));
            }
            else
            {
                Console.WriteLine("LowerCase = " + char.ToLower(c));
            }
        }
    }
}


