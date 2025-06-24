using Lab3;
using System;
using System.ComponentModel;


Lab_3 l = new Lab_3();

//1.Write a program to Create a divide by zero exception and handle it.
//l.DivideByZero(10, 0);

//2.Write a program that reads 5 numbers from user. Demonstrate concept of IndexOutOfRange Exception.
//l.ArrayIndexOut();

//3.Write a program to create an abstract class Sum having abstract methods SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c).
//Create another class Calculate which extends the abstract class and implements the abstract methods.
//Calculate c =new Calculate();
//Console.WriteLine("Sum of Two = " + c.SumofTwo(10, 20));
//Console.WriteLine("Sum of Three = " + c.SumofThree(10, 20,30));


//4.Write a program to create interface Calculate. In this interface we have two member functions Addition() and Subtraction().
//Implements this interface in another class named Result.
//Result r = new Result();
//r.Addition(10, 20);
//r.Subtraction(10, 20);

//5.Write program showing use of common methods of String class.
#region StringMethods
//string str = "Hello World!";
//Console.WriteLine("Original String: " + str);
//Console.WriteLine("Length of String: " + str.Length);
//Console.WriteLine("Uppercase: " + str.ToUpper());
//Console.WriteLine("Lowercase: " + str.ToLower());
//Console.WriteLine("Substring (0, 5): " + str.Substring(0, 5));
//Console.WriteLine("Contains 'World': " + str.Contains("World"));
//Console.WriteLine("Index of 'World': " + str.IndexOf("World"));
//Console.WriteLine("Replace 'World' with 'C#': " + str.Replace("World", "C#"));
//Console.WriteLine("Split by space: " + string.Join(", ", str.Split(' ')));
//Console.WriteLine("Trimmed String: " + str.Trim());
//Console.WriteLine("Starts with 'Hello': " + str.StartsWith("Hello"));
//Console.WriteLine("Ends with 'World!': " + str.EndsWith("World!"));
//Console.WriteLine("Character at index 7: " + str[7]);
//Console.WriteLine("String to Char Array: " + string.Join(", ", str.ToCharArray()));
#endregion

//6. Write a program to Replace lower case characters to upper case and Vice-versa.
//StringCase s = new StringCase();
//s.ViceVersa("Darsh ViPanI");

//7.Write a program to create interface named Shape.In this interface, we have three methods Circle(), Triangle() and Square()
//which calculates area of Circle, Triangle and Square respectively. Implement Shape interface.
//Shape2 s2 = new Shape2();
//s2.Circle(5);
//s2.Triangle(4, 5);
//s2.Square(4);

//8.Write a program to accept a number from the user and throw an exception if the number is not an even number.
//EvenNoException e = new EvenNoException();
//e.Add(4);

//9.Write a program to find the longest word in a string.
Long l1 = new Long();
//l1.Word("Hello World , Darsh Vipani");

//10.Write a program to change the case of entered character.
l1.CharChange('D');