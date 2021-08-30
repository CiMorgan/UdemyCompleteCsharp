using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UdemyCompleteCsharp11
{
    //class Program   //Arrays
    //{
    //    //4 ways to create an array in C#
    //    static string[] strings = new string[3];
    //    static string[] strings1 = new string[3] { "dog", "cat", "elephant" };
    //    static string[] strings2 = new string[] { "dog", "cat", "elephant" };
    //    static string[] strings3 = { "dog", "cat", "elephant" }; //will need to use the new keyword if initialized later
    //    public static void Main(string[] args)
    //    {
    //        strings1[1] = "not cat";
    //        Array.Sort(strings2);
    //        Console.WriteLine(strings[1]);
    //        Console.WriteLine(strings1[1]);
    //        Console.WriteLine(strings2[1]);
    //        Console.WriteLine(strings3[1]);
    //        foreach(string str in strings2)
    //        {
    //            Console.WriteLine(str);
    //        }
    //    }
    //}

    //class Program  //Lists
    //{
    //    static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(numbers.Count);
    //        numbers.Capacity=10; //limits list to 10 elements
    //        numbers.Add(6); //adds 6 to end of list
    //        numbers.Sort();
    //        foreach(int i in numbers)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.WriteLine("Index of element 5 is: " + numbers.BinarySearch(5));
    //        Console.WriteLine(numbers.Contains(3));
    //        Console.WriteLine(numbers.Contains(20));
    //        numbers.Insert(2, 20);
    //        List<int> subList = new List<int>() { 19, 18, 17, 16 };
    //        numbers.InsertRange(3, subList);
    //        bool areNumbersLessThan6 = numbers.TrueForAll(x => x < 6);
    //        Console.WriteLine(areNumbersLessThan6);
    //        numbers.Sort();
    //        numbers.RemoveRange(6, 5);
    //        foreach (int i in numbers)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        bool areNumbersLessThan7 = numbers.TrueForAll(x => x < 7);
    //        Console.WriteLine(areNumbersLessThan7);
    //        numbers.Reverse();
    //        foreach (int i in numbers)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}

    //class Program //stacks
    //{
    //    public static void Main(string[] args)
    //    {
    //        //Stack<string> s = new Stack<string>();
    //        //s.Push("cat");
    //        //s.Push("ant");
    //        //Console.WriteLine("The stack contains " + s.Count + " elements.");
    //        //Console.WriteLine(IsBalanced("{[<>]}"));
    //        //Console.WriteLine(IsBalanced("{[<>)]}"));
    //        //Console.WriteLine(IsBalanced("{(<>]}"));

    //        Stack stack = new Stack();
    //        stack.Push(1);
    //        stack.Push(2);
    //        stack.Push(3);

    //        Console.WriteLine(stack.Pop());  //last in 3
    //        Console.WriteLine(stack.Pop());  //2
    //        Console.WriteLine(stack.Pop());  //1
    //    }
    //    //Balanced Bracket Problem

    //    //private static bool IsBalanced(string inputString)
    //    //{
    //    //    Stack<char> stackOfClosingBraces = new Stack<char>();
    //    //    Stack<char> stackOfOpeningBraces = new Stack<char>();
    //    //    foreach (char c in inputString)
    //    //    {
    //    //        if (c == '}' || c == ']' || c == ')' || c == '>')
    //    //        {
    //    //            stackOfClosingBraces.Push(c);
    //    //        }
    //    //    }
    //    //    for(int i = inputString.Length - 1; i >= 0; i--)
    //    //    {
    //    //        if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(' || inputString[i] == '<')
    //    //        {
    //    //            stackOfOpeningBraces.Push(inputString[i]);
    //    //        }
    //    //    }
    //    //    if(stackOfClosingBraces.Count != stackOfOpeningBraces.Count)
    //    //    {
    //    //        return false;
    //    //    }
    //    //    while(stackOfClosingBraces.Count != 0)
    //    //    {
    //    //        char currentClosingBrace = stackOfClosingBraces.Pop(); //remove top char in closing braces stack
    //    //        char currentOpeningBrace = stackOfOpeningBraces.Pop(); //remove top char in opening braces stack
    //    //        if((currentOpeningBrace == '(' &&  currentClosingBrace == ')') ||
    //    //            (currentOpeningBrace == '[' && currentClosingBrace == ']') ||
    //    //            (currentOpeningBrace == '{' && currentClosingBrace == '}') ||
    //    //            (currentOpeningBrace == '<' && currentClosingBrace == '>'))
    //    //        {
    //    //            continue;
    //    //        }
    //    //        else
    //    //        {
    //    //            return false;
    //    //        }
    //    //    }
    //    //    return true;
    //    //}
    //public class Stack
    //    {
    //        const int MAX = 1000;   //maximum number of elements the stack can hold
    //        int top;                //index of top element in stack
    //        object[] stack = new object[MAX];   //object array to hold elements in stack

    //        public Stack()          //constructor
    //        {
    //            top = -1;           //indicates stack is empty
    //        }

    //        public void Push(object obj)
    //        {
    //            if (top < MAX)  //can stack hold object
    //            {
    //                stack[++top] = obj;
    //            }
    //        }

    //        public object Pop()
    //        {
    //            if (top >= 0)  //is stack empty
    //            {
    //                object o = stack[top];
    //                top--;
    //                return o;
    //            }
    //            else
    //            {
    //                return -1; //indicates stack is empty
    //            }
    //        }

    //        public object Peek()
    //        {
    //            return stack[top];
    //        }

    //    }
    //}
    //public class Program //queues
    //{
    //    public static void Main(string[] args)
    //    {
    //        Queue<string> queue = new Queue<string>();
    //        queue.Enqueue("a");
    //        queue.Enqueue("b"); 
    //        queue.Enqueue("c");
    //        Console.WriteLine(queue.Dequeue());

    //    }
    //}
    //public class Program //structs
    //{
    //    struct Example : INotifyPropertyChanged
    //    {
    //        string Ex;
    //        int Ex2;

    //        public event PropertyChangedEventHandler PropertyChanged;
    //    }
    //    public static void Main(string[] args)
    //    {


    //    }
    //}

    //public class Program // enums
    //{
    //    enum Weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    //    static Weekday dayOfTheWeek = Weekday.Wednesday;
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(Enum.GetName(typeof(Weekday), 6));
    //        foreach (string s in Enum.GetNames(typeof(Weekday)))
    //        {
    //            Console.WriteLine(s);
    //        }
    //        foreach (int i in Enum.GetValues(typeof(Weekday)))
    //        {
    //            Console.WriteLine(i);
    //        }

    //        switch (dayOfTheWeek)
    //        {
    //            case Weekday.Monday:
    //                Console.WriteLine("It's Monday");
    //                break;
    //            case Weekday.Tuesday:
    //                Console.WriteLine("It's Tuesday");
    //                break;
    //            case Weekday.Wednesday:
    //                Console.WriteLine("It's Wednesday");
    //                break;
    //            case Weekday.Thursday:
    //                Console.WriteLine("It's Thursday");
    //                break;
    //            case Weekday.Friday:
    //                Console.WriteLine("It's Friday");
    //                break;
    //            case Weekday.Saturday:
    //                Console.WriteLine("It's Saturday");
    //                break;
    //            case Weekday.Sunday:
    //                Console.WriteLine("It's Sunday");
    //                break;

    //        }

    //    }
    //}

    //public class MainClass   //Dictionaries - uses key vakue pairs
    //{
    //    public static void Main(string[] args)
    //    {
    //        Dictionary<string, string> dictionary = new Dictionary<string, string>();
    //        dictionary.Add("key1", "value1");
    //        dictionary.Add("key2", "value2");
    //        dictionary.Add("key3", "value3");
    //        dictionary.Add("key4", "value4");
    //        Console.WriteLine(dictionary.Count);
    //        //can't iterate over dictionary but can iterate over keys or values
    //        foreach(string key in dictionary.Keys)
    //        {
    //            Console.WriteLine(key);
    //        }

    //        foreach (string value in dictionary.Values)
    //        {
    //            Console.WriteLine(value);
    //        }
    //        Console.WriteLine(dictionary["key2"]);

    //        string val1 = "";
    //        string val2 = "";
    //        dictionary.TryGetValue("key3", out val1);
    //        dictionary.TryGetValue("key5", out val2);
    //        Console.WriteLine(val2);
    //        Console.WriteLine(val1);
    //    }
    //}

    //public class Example  //HashSets
    //{
    //    public static void Main(string[] args)
    //    {
    //        HashSet<string> letters1 = new HashSet<string>() { "a", "b", "c" };
    //        HashSet<string> letters2 = new HashSet<string>() { "d", "e", "f" };
    //        HashSet<string> letters3 = new HashSet<string>() { "e", "f", "g", "h" };
    //        letters1.UnionWith(letters2);
    //        foreach (string s in letters1)
    //        {
    //            Console.WriteLine(s);
    //        }

    //        letters2.IntersectWith(letters3);
    //        foreach (string s in letters2)
    //        {
    //            Console.WriteLine(s);
    //        }



    //    }
    //}

    //public class Example  //Sorted Lists
    //{
    //    static SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };
    //    public static void Main(string[] args)
    //    {
    //        sortedList.Capacity = 6;
    //        Console.WriteLine("The sorted list's capacity is: " + sortedList.Capacity);
    //        Console.WriteLine("The sorted list's count is: " + sortedList.Count);

    //        foreach(string key in sortedList.Keys)
    //        {
    //            Console.WriteLine(key);
    //        }

    //        foreach (int val in sortedList.Values)
    //        {
    //            Console.WriteLine(val);
    //        }
    //    }
    //}

    //public class Example  //Sorted Dictionaries
    //{
    //    static SortedDictionary<string, string> sortedDictionry = new SortedDictionary<string, string>() { { "key1", "value1" }, { "key2", "value2" }, { "key3", "value3" } };
    //    public static void Main(string[] args)
    //    {
    //        sortedDictionry.Add("key4", "value4");

    //        Console.WriteLine(sortedDictionry.ContainsKey("key2"));
    //        Console.WriteLine(sortedDictionry.ContainsKey("key5"));

    //    }


    //}
    //public class Example  //Sorted Sets
    //{
    //    static SortedSet<int> sortedSet = new SortedSet<int>();
    //    public static void Main(string[] args)
    //    {
    //        sortedSet.Add(3);
    //        sortedSet.Add(1);
    //        sortedSet.Add(-1);
    //        sortedSet.Add(0);

    //        foreach (int i in sortedSet)
    //        {
    //            Console.WriteLine(i);
    //        }

    //        if (sortedSet.Contains(1))
    //        {
    //            Console.WriteLine("It contains 1.");
    //        }
    //        if (!sortedSet.Contains(5))
    //        {
    //            Console.WriteLine("It does not contain 5.");
    //        }

    //        SortedSet<int> set1 = new SortedSet<int>() { 1, 3};
    //        Console.WriteLine(sortedSet.IsSubsetOf(set1));  //false
    //        Console.WriteLine(sortedSet.IsSupersetOf(set1));  //true


    //    }
    //}
    //public class Example  //Tuples
    //{
    //    public static void Main(string[] args)
    //    {
    //        Tuple<int> tuple = Tuple.Create(1);   //2 ways to create tuples
    //        Tuple<int> tuple2 = new Tuple<int>(3);
    //        Tuple<int, int, int> tuple3 = new Tuple<int, int, int>(1, 3, 5);
    //        Tuple<int, string, bool> tuple4 = new Tuple<int, string, bool>(7, "Hello World!", true);

    //        Console.WriteLine(tuple4.Item2);
    //    }
    //}
    //public class Example  //Linked Lists - singly
    //{
    //    //create singly linked list
    //    public class LinkedList
    //    {
    //        public class Node
    //        {
    //            public Node next;
    //            public object data;
    //        }

    //        private Node root;
    //        public Node First { get; { return root; } }
    //        public Node Last
    //        {
    //            get
    //            {
    //                Node currentNode = root;  //puts us at start of list
    //                if(currentNode == null)
    //                {
    //                    return null;
    //                }
    //                while(currentNode != null)
    //                {
    //                    currentNode = currentNode.next;
    //                }

    //                return currentNode;
    //            }
    //        }
    //        public void Append(object value)
    //        {
    //            Node node = new Node { data = value };
    //            if (root == null)
    //            {
    //                root = node;
    //            }
    //            else
    //            {
    //                Last.next = node;
    //            }
    //        }
    //        public void Delete (Node node)
    //        {
    //            if (root == node)
    //            {
    //                root = node.next;
    //                node.next = null;
    //            }
    //            else
    //            {
    //                Node current = root;
    //                while (current.next != null)
    //                {
    //                    if (current.next == node)
    //                    {
    //                        current.next = node.next;
    //                        node.next = null;
    //                        break;
    //                    }
    //                    current = current.next;
    //                }
    //            }
    //        }


    //    }
    //    public static void Main(string[] args)
    //    {

    //    }
    //}
    //public class Example //Linked Lists - Doubly
    //{
    //    static LinkedList<string> linkedList = new LinkedList<string>(); 
    //    public static void Main(string[] args)
    //    {
    //        linkedList.AddFirst("root");
    //        linkedList.AddAfter(linkedList.First, "element");
    //        linkedList.AddBefore(linkedList.First, "new root");
    //        linkedList.AddAfter(linkedList.Last, "element 2");
    //        linkedList.AddLast("last element");
    //        foreach(string a in linkedList)
    //        {
    //            Console.WriteLine(a);
    //        }
    //    }
    //}

    //Trees
    //class Example
    //{
    //    public static void Main(string[] args)
    //    {
    //        TreeNode<string> a = new TreeNode<string>("a");
    //        TreeNode<string> b = new TreeNode<string>("b");
    //        TreeNode<string> c = new TreeNode<string>("c");
    //        //TreeNode<string> d = new TreeNode<string>("d");
    //        //TreeNode<string> e = new TreeNode<string>("e");
    //        //TreeNode<string> f = new TreeNode<string>("f");
    //        //TreeNode<string> g = new TreeNode<string>("g");

    //        a.SetLeft(b);
    //        a.SetRight(c);
    //        //b.SetLeft(d);
    //        //c.SetLeft(e);
    //        //e.SetLeft(f);
    //        //e.SetRight(g);

    //        //PreOrder(a);
    //        //InOrder(a);
    //        //PostOrder(a);
    //        Console.WriteLine(IsBalanced(a));

    //        //Console.WriteLine(Program<string>.GetHeight(a));
    //    }
    //    static void PreOrder(TreeNode<string> root)  //get root first followed by left node and right node
    //    {
    //        if(root != null)
    //        {
    //            Console.WriteLine(root.GetValue().ToString() + " ");
    //            PreOrder(root.GetLeft());
    //            PreOrder(root.GetRight());
    //        }
    //    }

    //    static void InOrder(TreeNode<string> root)  //get left node first followed by root and right node
    //    {
    //        if (root != null)
    //        {
    //            InOrder(root.GetLeft());
    //            Console.WriteLine(root.GetValue().ToString() + " ");
    //            InOrder(root.GetRight());
    //        }
    //    }

    //    static void PostOrder(TreeNode<string> root)  //get left node first followed by right node and then root
    //    {
    //        if (root != null)
    //        {
    //            PostOrder(root.GetLeft());
    //            PostOrder(root.GetRight());
    //            Console.WriteLine(root.GetValue().ToString() + " ");
    //        }
    //    }

    //    static bool IsBalanced(TreeNode<string> root)  //Still needs to be troubleshooted 
    //    {
    //        int diff = 0;

    //        if ((root.GetLeft() != null && root.GetRight() == null) || (root.GetLeft() == null && root.GetRight() != null))
    //        {
    //            diff += 1;
    //        }
    //        else
    //        {
    //            diff = 0;
    //        }

    //        return IsBalanced(root.GetLeft()) && IsBalanced(root.GetRight());
    //    }

    //}
    //public class Program<T> 
    //{
    //    public static int GetHeight(TreeNode<T> root)
    //    {
    //        if(root==null) { return 0; }
    //        return Math.Max(GetHeight(root.GetLeft()), GetHeight(root.GetRight()) + 1);
    //    }     
    //}
    //public class TreeNode<T>  //T is a place holder for the type (int, string) of node
    //{
    //    T value;
    //    TreeNode<T> left = null;
    //    TreeNode<T> right = null;

    //    public TreeNode(T value)
    //    {
    //        this.value = value;
    //    }
    //    public TreeNode<T> GetLeft()
    //    {
    //        return left;
    //    }
    //    public TreeNode<T> GetRight()
    //    {
    //        return right;
    //    }
    //    public T GetValue()
    //    {
    //        return value;
    //    }
    //    public void SetValue(T value)
    //    {
    //        this.value = value;
    //    }
    //    public void SetRight(TreeNode<T> node)
    //    {
    //        right = node;
    //    }
    //    public void SetLeft(TreeNode<T> node)
    //    {
    //        left = node;
    //    }


    //}
    class Example
    {
        public static void Main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);

            Graph graph = new Graph(6);

            graph.AddEdge(six, four);
            graph.AddEdge(four, five);
            graph.AddEdge(five, two);
            graph.AddEdge(two, three);
            graph.AddEdge(four, three);
            graph.AddEdge(five, one);
            graph.AddEdge(two, one);
        }
    }
    class Node
    {
        public List<object> Neighbors { get; set; }
        public int Data;

        public Node(int data)
        {
            Data = data;
        }

    }

    class Graph
    {
        public int NumberOfVertices { get; set; }
        public List<Node> Vertices { get; set; }

        public Graph(int size)
        {
            NumberOfVertices = size;
            Vertices = new List<Node>();

            for(int i=0; i < NumberOfVertices; i++)
            {
                Vertices[i] = new Node();
            }
        }
        public void AddEdge(Node source, Node destination)
        {
            source.Neighbors.Add(destination);
            destination.Neighbors.Add(source);
        }

        public void RemoveEdge(Node source, Node destination)
        {
            source.Neighbors.Remove(destination);
            destination.Neighbors.Remove(source);
        }

        public bool IsAdjacent(Node node1, Node node2)
        {
            return node1.Neighbors.Contains(node2);
        }
    }


}



