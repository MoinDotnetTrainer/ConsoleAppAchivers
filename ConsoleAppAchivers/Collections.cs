using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAchivers
{

    public class Employees
    {
        public int EID { get; set; }
        public string EName { get; set; }
        public int Age { get; set; }
    }

    // group of data i Want to hold
    internal class Collections
    {
        // Array ---> Drawback of arrays len is fixed


        public void NonGen() {
            ArrayList al = new ArrayList();
            // dynamic arrays
            al.Add(4);
            al.Add("string");
            al.Add(true);
        }
        public void HoldEmpData() {
            Employees EMp = new Employees();
            EMp.EID = 34;
            EMp.EName = "Test";
            EMp.Age = 45;

            // Collections --> gen type , like a tool

            HashSet<Employees> employees = new HashSet<Employees>();
            employees.Add(new Employees { EID = 1, EName = "test1", Age = 23 });
            employees.Add(new Employees { EID = 2, EName = "test2", Age = 43 });
            employees.Add(new Employees { EID = 3, EName = "test3", Age = 34 });
            employees.Add(new Employees { EID = 4, EName = "test4", Age = 34 });
            employees.Add(new Employees { EID = 5, EName = "test5", Age = 12 });
            employees.Add(new Employees { EID = 6, EName = "test6", Age = 23 });
            employees.Add(new Employees { EID = 6, EName = "test6", Age = 23 });

            foreach (var item in employees)
            {
                Console.WriteLine($"Eid is {item.EID} , Name is {item.EName} & age is {item.Age}");
            }
        }

        public void Test()
        {
            int[] arr = new int[5] { 45, 56, 67, 78, 78 };

            // Collections is a dynamic arrays (no fixed lenth)--> added , removed easily
        }


        // Dup
        public void ListEx()
        {
            List<int> list = new List<int>();
            list.Add(45);
            list.Add(56);
            list.Add(567);
            list.Add(560);
            list.Add(567);
            list.Add(4455);
            list.Add(56);
            list.Add(45);
            list.Add(56);
            list.Add(567);
            list.Add(560);
            list.Add(567);
            list.Add(4455);
            list.Add(56);

            list.Remove(45);

            list.RemoveAt(2);

            list.Insert(2, 100);


            // arrys forloop  --> Condtion


            //Add method 

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }


        // no dup , not in assend
        public void Hashset()
        {
            HashSet<int> hash = new HashSet<int>();
            hash.Add(34);
            hash.Add(546);
            hash.Add(567);
            hash.Add(568);
            hash.Add(33545);
            hash.Add(34);
            hash.Add(546);
            hash.Add(567);
            hash.Add(568);
            hash.Add(33545);
            hash.Add(345);
            hash.Add(345);

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }


        // no 
        public void SortedSet()
        {
            SortedSet<int> SortedSet = new SortedSet<int>();
            SortedSet.Add(34);
            SortedSet.Add(546);
            SortedSet.Add(567);
            SortedSet.Add(568);
            SortedSet.Add(33545);
            SortedSet.Add(34);
            SortedSet.Add(34);
            SortedSet.Add(546);
            SortedSet.Add(567);
            SortedSet.Add(568);
            SortedSet.Add(33545);
            SortedSet.Add(34);
            SortedSet.Add(546);
            SortedSet.Add(567);
            SortedSet.Add(568);
            SortedSet.Add(33545);
            SortedSet.Add(345);
            SortedSet.Add(345);

            foreach (var item in SortedSet)
            {
                Console.WriteLine(item);
            }
        }

        public void Stack()
        {
            Stack<int> Stack = new Stack<int>();
            Stack.Push(345);
            Stack.Push(234);
            Stack.Push(34556);
            Stack.Push(12);
            Stack.Push(67);
            Stack.Push(674);
            Stack.Pop();


            //LILO

            foreach (var item in Stack)
            {
                Console.WriteLine(item);
            }
        }

        public void Queue()
        {
            Queue<int> Queue = new Queue<int>();
            Queue.Enqueue(345);
            Queue.Enqueue(234);
            Queue.Enqueue(34556);
            Queue.Enqueue(12);
            Queue.Enqueue(67);
            Queue.Enqueue(674);
            Queue.Dequeue();

            foreach (var item in Queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
