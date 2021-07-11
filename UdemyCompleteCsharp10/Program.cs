using System;
using System.ComponentModel;

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

    class Program3: IComparable
    {
        public int exampleLength;
        Program3 ex1 = new Program3() { exampleLength = 2 };

        public static void Main(string[] args)
        {

        }

        public int CompareTo(object obj)
        {
            Program3 ex2 = (Program3)obj;
            if (ex1.exampleLength == ex2.exampleLength)
            {
                return 0;
            }
            else if (ex1.exampleLength > ex2.exampleLength)
            {
                return 1;
            }
            else
            {
                return -1;
            }
                
        }
    }
}
