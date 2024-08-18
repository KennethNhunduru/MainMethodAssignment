using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*In C# there are two common approaches to calling a method from a different class:
             1. by creating an instance of the class with the method to be called in the new class 
                and in this case the method is necessarily declared as NOT STATIC.
             2. by using static methods, whereby if the method is declared as STATIC, in which case 
                it can be called directly using its class name.*/

            MethodOverloading method1 = new MethodOverloading(); //instantiating the class
            int num1 = 6; //assigning an integer argument for the method parameter.
            method1.Overload(num1); //calling the method, and passing in an integer value argument.
            Console.ReadLine(); //Displaying the result

            MethodOverloading method2 = new MethodOverloading(); //instantiating the class
            Decimal dec1 = 8.0M; //assigning a decimal argument for the method parameter.
            int num3 = 4; //assigning an integer argument for the method parameter.
            method2.Overload(dec1, num3); //calling the method, and passing in a decimal and an integer value arguments.
            Console.ReadLine();

            MethodOverloading method3 = new MethodOverloading(); //instantiating the class
            string str1 = "444"; //assigning a string argument for the method parameter.
            int num5 = 4; //assigning an integer argument for the method parameter.
            method3.Overload(str1, num5); //calling the method, and passing in a string and an integer value arguments.
            Console.ReadLine();
        }        
    }
}
