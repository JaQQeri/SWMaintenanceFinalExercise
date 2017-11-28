using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Software Maintenance
    Jani Lamppu, 1401565
    Math functions DLL
*/

namespace MathFunctions
{
    public class Class1
    {
        /**
        * A mathematical function that calculates the area of the given measurements.
        * @param n Specifies height.
        * @param m Specifies width.
        * @return The calculated output (area).
        */
        public double CalculateArea(double n, double m)
        {
            return n * m;
        }

        /**
        * A mathematical function that calculates the capacity of the given measurements.
        * @param n Specifies height.
        * @param m Specifies width.
        * @param c Specifies depth.
        * @return The calculated output (capacity).
        */
        public double CalculateCapacity(double n, double m, double c)
        {
            return n * m * c;
        }

        /**
        * A function that checks if the given input string is a valid integer to be used in the application.
        * @param input The string to be validated.
        * @return true/false depending if the input is valid or not.
        */
        public bool IsInputValidInteger(string input)
        {
            int res;
            return int.TryParse(input, out res);
        }

        /**
        * A function that checks if the given input string is a valid double to be used in the application.
        * @param input The string to be validated.
        * @return true/false depending if the input is valid or not.
        */
        public bool IsInputValidDouble(string input)
        {
            double res;
            return Double.TryParse(input, out res);
        }
    }
}
