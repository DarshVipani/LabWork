using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

#region Question 1
//1. Create an ArrayList for StudentName and perform following operations:
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index
//c. RemoveRange() - To Remove student with specified range.
//d. Clear() - To clear all the student from the list

//ArrayList a = new ArrayList();
//a.Add("Darsh");
//a.Add("Jado");
//a.Add("Chotuu");
//a.Add("Bsc Hons");
//a.Add("Msc Hons");
//a.Add("Phd Hons");
//a.Add("John Doe");

//a.Remove("Chotuu"); // Remove by value

//a.RemoveRange(4,2); // Remove range starting from index 4, removing 2 items

//Console.WriteLine(a.Count);
//Console.WriteLine(a.IndexOf("Chotuu")); // Find index of "Darsh"

//a.Clear(); // Clear all items in the ArrayList
//foreach (var item in a)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Question 2
//2.Create a List for StudentName and perform following operations:
//a.Add() - To Add new student in list
//b.Remove() - To Remove Student with specified index
//c. RemoveRange() - To Remove student with specified range.
//d. Clear() - To clear all the student from the list

//List<String> l = new List<String>();

//l.Add("Darsh");
//l.Add("Jado");
//l.Add("Chotuu");
//l.Add("Bsc Hons");
//l.Add("Msc Hons"); 
//l.Add("Phd Hons");
//l.Add("John Doe");
//l.Add("Jane Doe");
//l.Add("Alice");

//l.Remove("Jado");

//l.RemoveRange(2, 3);

////l.Sort();

////l.Clear(); // Clear all items in the List
//foreach (var ele in l)
//{
//    Console.WriteLine(ele); 
//}
#endregion

#region Question 3
//3.Create a Stack which takes integer values and perform following operations:
//a.Push() - To Add new item in stack
//b.Pop() - To Remove item from the stack
//c. Peek() – To Return the top item from the stack.
//d. Contains() - To Checks whether an item exists in the stack or not.
//e. Clear() - To clear items from stack

//Stack<int> s = new Stack<int>();
//s.Push(10);
//s.Push(20);
//s.Push(30);
//s.Push(40);
//s.Push(50);
//s.Push(60);

//s.Pop(); // Removes the top item (60)

//Console.WriteLine("Peek = "+s.Peek());

//Console.WriteLine("Contains = " + s.Contains(30)); // Checks if 30 is in the stack

//s.Clear(); // Clear all items in the Stack

//foreach (var item in s)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Question 4
//4. Create a Queue which takes integer values and perform following operations:
//a.Enqueue() - Adds an item into the queue.
//b. Dequeue() - Returns an item from the beginning of the queue and
//removes it from the queue.
//c. Peek() - Returns an first item from the queue without removing it.
//d. Contains() - Checks whether an item is in the queue or not
//e. Clear() - Removes all the items from the queue

//Queue<int> q = new Queue<int>();
//q.Enqueue(10);
//q.Enqueue(20);
//q.Enqueue(30);
//q.Enqueue(40);
//q.Enqueue(50);
//q.Enqueue(60);

//q.Dequeue(); // Removes the first item (10)

//Console.WriteLine("Peek = "+q.Peek());

//Console.WriteLine("Contains = "+q.Contains(10));

//q.Clear(); // Clear all items in the Queue

//foreach (var item in q)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Question 5
//5.Create a Dictionary collection class object and preform following operations:
//a.Add: Adds a key-value pair.
//b.Remove: Removes a key-value pair by key.
//c.ContainsKey: Checks if a key exists in the hashtable.
//d.ContainsValue: Checks if a value exists in the hashtable.
//e.Clear: Removes all key-value pairs.

//Dictionary<int,string> d = new Dictionary<int, string>();
//d.Add(1, "Darsh");
//d.Add(2, "Jado");
//d.Add(3, "Chotuu");
//d.Add(4, "Bsc Hons");
//d.Add(5, "Msc Hons");
//d.Add(6, "Phd Hons");

//d.Remove(3);

//Console.WriteLine("Contains Key = "+d.ContainsKey(2));

//Console.WriteLine("Contains Val = " + d.ContainsValue("Chotuu"));

//d.Clear();

//foreach (var item in d)
//{
//    Console.WriteLine(item.Value);    
//}
#endregion

#region Question 6
//6.Create a Hashtable collection class object and preform following operations:
//a.Add: Adds a key-value pair.
//b.Remove: Removes a key-value pair by key.
//c.ContainsKey: Checks if a key exists in the hashtable.
//d.ContainsValue: Checks if a value exists in the hashtable.
//e.Clear: Removes all key-value pairs.

//Hashtable h = new Hashtable();
//h.Add(1, "Darsh");
//h.Add(2, "Jado");
//h.Add(3, "Chotuu");
//h.Add(4, "Bsc Hons");
//h.Add("hello", "Msc Hons");
//h.Add(6, "Phd Hons");

//h.Remove(3); // Remove by key

//Console.WriteLine(h.ContainsKey(2));
//Console.WriteLine(h.ContainsValue("Jado"));

//h.Clear(); // Clear all items in the Hashtable
//foreach (var item in h)
//{
//    Console.WriteLine(item);
//}
#endregion
