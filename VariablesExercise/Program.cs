using System.Runtime.CompilerServices;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Jeff";

            int myAge = 18;
            //For character make sure that you surround the cahracter after the qual line with single quotes

            char myFirstNameInitial = 'J';
            bool age = true;
            double num = 3.13;
            decimal pie = 3.14m;
            //WE use $ symbol to add strubg interpolation
            Console.WriteLine($"My Name is {myName}, I am {myAge} years old. The initial to my first name is {myFirstNameInitial}. My age is {age}. My favorite decimal is {num}. If you add .01 to it then it will be the number of pie which is {pie}"); 


            
        }
    }
}