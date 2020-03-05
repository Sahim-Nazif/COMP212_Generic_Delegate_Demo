using System;

namespace COMP212_GenericDelegate_Demo
{
    //creating a generic delegate 
    public delegate T add<T>(T a, T b);
    class Program
    {
        static void Main(string[] args)
        {

            add<int> Sum = AddNumber;
            Console.WriteLine("Result of addition is:" + Sum(12,33));

            add<string> JoinStrings= Concat;
            Console.WriteLine(JoinStrings("This is " , "Generic Delegate Demo"));


        }
        public static int AddNumber(int a, int b)
        {
            return a + b;
        }
        public static string Concat(string a, string b)
        {
            return a + b;
        }
    }
}
