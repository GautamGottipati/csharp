using System;

namespace FirstApplicartion
{
    class Program
    {
        /// <summary>
        /// This is an add method <param name="a"> a</param> and <param name="b"> b</param>
        /// </summary>
        /// 
        /// <returns>
        /// Sum of 2 numbers
        /// </returns>
        /// <example>
        /// <code>
        /// int a = add(5,3)
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException">
        /// Throws when one parameter is max and other is greater than 0.
        /// </exception>
        public static int add(int a,int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(add(5, 3));
        }
    }
}
