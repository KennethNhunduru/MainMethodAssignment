using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MethodOverloading
    {
        //CREATING THE FIRST ARITHMETIC METHOD

        /*The first method, Overload, takes an integer and prefix increments it by 1 and 
         returns the result*/

        public int Overload(int num1)
        {
            int num2 = num1;
            int result = ++num1;
            //displaying the result to the screen.
            Console.WriteLine("The result of prefix-incrementing " + num2 + " is: " +  result);
            return result;
        }

        //CREATING THE SECOND ARITHMETIC METHOD

        /*The second method, also named Overload, takes a decimal(128-bit precise decimal values with 28-29 significant digits.),
         does a math operation on it, and returns an integer result*/

        /*NOTE THAT ALTHOUGH THE SECOND METHOD HAS THE SAME NAME AS THE FIRST METHOD, THIS IS POSSIBLE BECAUSE THE TWO METHODS 
         WILL HAVE DIFFERENT DATATYPE PARAMETERS, AND DIFFERENT NUMBER OF PARAMETERS, AND THAT IS CALLED METHOD OVERLOADING.*/

        /*The variables from the Decimal datatype can only be operated together with either integer or decimal literals. 
         
The result or output is always of the decimal datatype. This means the only way to get an integer result from 
         such an operation is to make use of a cast to achieve explicit numeric conversion */

        public int Overload(decimal dec1, int num3)
        {
            int result = Convert.ToInt32(dec1 * num3);
            //displaying the result to the screen.
            Console.WriteLine("The integer product of the decimal and integer literals is: " + result);
            return result;
        }

        //CREATING THE THIRD ARITHMETIC METHOD

        /*The third method, also named Overload, takes a string, converts it to an integer if possible, 
         does a different math operation to it, and returns the answer as an integer.*/

        /*NOTE THAT ALTHOUGH THE THIRD METHOD HAS THE SAME NAME AS THE FIRST AND SECOND METHODS, THIS IS POSSIBLE BECAUSE 
         THE THREE METHODS WILL HAVE DIFFERENT DATATYPES FOR THE PARAMETERS, AND DIFFERENT NUMBERS OF PARAMETERS, 
         AND THAT IS THE PREREQUISITE FOR METHOD OVERLOADING.*/

        /*When we request numerical input from a user, we capture the input in the form of a string from the keyboard strokes.
         For this input to be useful for numerical operations, it needs to be cast to the integer format. 
         C# provides a method to convert strings into integers: Convert.ToInt32.*/

        public int Overload(string str1, int num5)
        {
            int num4 = Convert.ToInt32(str1);
            int result = num4 + num5;
            //displaying the result to the screen.
            Console.WriteLine("The sum of the string input and integer num5 is: " + result);
            return result;
        }

    }
}
