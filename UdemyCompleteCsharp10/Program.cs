using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace UdemyCompleteCsharp10
{
    //class Program : IExample, ISecondExample   //separate interfaces with commas
    //{
    //    static void Main(string[] args) //need to use all methods in the interface(s) otherwise it will not compile
    //    {
    //        Console.WriteLine("Hello World!");
    //    }

    //    public void Example()
    //    {
    //        Console.WriteLine("Hello World");
    //    }

    //    public int Example2(int n)
    //    {
    //        return 1;
    //    }

    //    public string Example3(string str1, string str2)
    //    {
    //        return str1 + " " + str2;
    //    }
    //}
    //interface IExample   //C# convention to begin interfaces with I
    //{
    //    void Example();  //includes method signature but not method itself
    //    int Example2(int n);
    //    string Example3(string str1, string str2);
    //}

    //interface ISecondExample { }

    //class Program2 : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged; //auto filled with Quick actions and refactoring
    //    public string Name
    //    {
    //        get
    //        {
    //            return Name;
    //        }
    //        set
    //        {
    //            Name = value;
    //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
    //        }
    //    }

    //    static void Main(string[] args)
    //    {

    //    }
    //}

    //class Program3: IComparable
    //{
    //    public int exampleLength;
    //    Program3 ex1 = new Program3() { exampleLength = 2 };

    //    public static void Main(string[] args)
    //    {

    //    }

    //    public int CompareTo(object obj)
    //    {
    //        Program3 ex2 = (Program3)obj;
    //        if (ex1.exampleLength == ex2.exampleLength)
    //        {
    //            return 0;
    //        }
    //        else if (ex1.exampleLength > ex2.exampleLength)
    //        {
    //            return 1;
    //        }
    //        else
    //        {
    //            return -1;
    //        }

    //    }
    //}
    //class Program4 : IComparer
    //{
    //    class Employee
    //    {
    //        public int Id;
    //    }
    //    public static void Main(string[] args)
    //    {

    //    }

    //    public int Compare(object x, object y)
    //    {
    //        Employee employee1 = (Employee)x;
    //        Employee employee2 = (Employee)y;
    //        return employee1.Id.CompareTo(employee2.Id);
    //    }
    //}
    //class Program4 : IEquatable<Program4>
    //{
    //    public string exampleData;

    //    public static void Main(string[] args)
    //    {

    //    }

    //    public bool Equals([AllowNull] Program4 other)  //determine whether or not 2 things are equal
    //    {
    //        if(other == null)
    //        {
    //            return false;
    //        }
    //        return exampleData.GetHashCode().Equals(other.exampleData.GetHashCode());
    //    }
    //}
    //public class Officer
    //{
    //    Guid id;
    //    public Guid Id
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //}
    //class Program5 : IEqualityComparer<Officer>
    //{
    //    public static void Main(string[] args)
    //    {

    //    }

    //    public bool Equals([AllowNull] Officer x, [AllowNull] Officer y) //takes in 2 objects of the type in angular brackets
    //    {
    //        return x.Id == y.Id;
    //    }

    //    public int GetHashCode([DisallowNull] Officer obj)  //takes in one parameter of the type in angular brackets
    //    {
    //        return obj.Id.GetHashCode();
    //    }
    //}
    class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;   //next slot in wallet not taken up by a bill; keeps track of the next open index in the array

        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if (bill == null)
                {
                    break;
                }
                yield return bill;
            }
        }
    }
    class Money
    {
        public int amount;
    }
    class Program6
    {
        public static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });
            foreach (Money money in wallet)
            {
                Console.WriteLine("Bill: " + money.amount);
            }

        }
    }
}
