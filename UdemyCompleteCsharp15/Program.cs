using System;

namespace UdemyCompleteCsharp15
{
    // XML documentation start with/// 
    // XML documents can generate an XML file at compile time; allow IntelliSense to show custom information
    // Use tool like DocFX and SandCastle to convert XML to documantation
    
    
    
    
    /// <summary>
    /// The Example class is used for tutorials
    /// </summary>
    /// <remarks>
    /// More info about the class goes here.
    /// </remarks>
    public class Example
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <example>
        /// <code>
        /// int c= Example.Add(1,2);
        /// </code>
        /// </example>
        /// <returns>The sum of two integers.</returns>
        public static int Add( int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// Gets the value of Val.
        /// </value>
        /// <remarks>
        /// <para>
        /// More info goes here.
        /// </para>
        /// </remarks>
        public static string Val { get; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">An int</param>
        /// <param name="b">An int</param>
        /// <returns></returns>
        /// <exception cref="System.DivideByZeroException">Thrown when we attempt to divide by zero.</exception>
        /// <see cref="Example.Divide(int, int)"/> to divide integers
        /// <seealso cref="Example.Divide(int, int)"/>
        public static int Divide(int a, int b)
        {
            return a / b;
        }

    }
}
