using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace MainApplication
{
    /*! Main class for the application executable. */
    class Program
    {
        static void Main(string[] args)
        {
            int runCount = 0;
            if (args.Length == 0)
            {
                Console.WriteLine("No command line arguments specified!");
                Console.WriteLine(".. Press any key to continue ..");
                Console.ReadLine();
                return;
            }
            else
            {
                // Get program run count from registry
                if (Registry.GetValue(Constants.RegistryKey, Constants.GivenIntegerValue, null) != null) runCount = (int)Registry.GetValue(Constants.RegistryKey, Constants.GivenIntegerValue, null);
                else Registry.SetValue(Constants.RegistryKey, Constants.GivenIntegerValue, runCount);

                if (runCount == 0) Console.WriteLine("This is your first time running this application.");
                else Console.WriteLine("This program has been ran " + (runCount == 1 ? "once before." : runCount + " times before."));

                MathFunctions.Class1 mathOperations = new MathFunctions.Class1();
                string input = "";
                double height = 0, width = 0, depth = 0;
                switch(args[0])
                {
                    case "-a":

                        Console.WriteLine("Received command line argument -a (calculate area)");
                        Console.WriteLine("Please enter height:");
                        input = Console.ReadLine();
                        while (!mathOperations.IsInputValidDouble(input))
                        {
                            Console.WriteLine("Invalid input! Please try again.");
                            input = Console.ReadLine();
                        }

                        height = Convert.ToDouble(input);
                        Console.WriteLine("Please enter width:");
                        input = Console.ReadLine();
                        while (!mathOperations.IsInputValidDouble(input))
                        {
                            Console.WriteLine("Invalid input! Please try again.");
                            input = Console.ReadLine();
                        }

                        width = Convert.ToDouble(input);
                        Console.WriteLine("Area is " + mathOperations.CalculateArea(height, width));
                        break;

                    case "-b":

                        Console.WriteLine("Received command line argument -b (calculate capacity)");
                        Console.WriteLine("Please enter height:");
                        input = Console.ReadLine();
                        while (!mathOperations.IsInputValidDouble(input))
                        {
                            Console.WriteLine("Invalid input! Please try again.");
                            input = Console.ReadLine();
                        }

                        height = Convert.ToDouble(input);

                        Console.WriteLine("Please enter width:");
                        input = Console.ReadLine();
                        while (!mathOperations.IsInputValidDouble(input))
                        {
                            Console.WriteLine("Invalid input! Please try again.");
                            input = Console.ReadLine();
                        }
                        width = Convert.ToDouble(input);
               
                        Console.WriteLine("Please enter depth:");
                        input = Console.ReadLine();
                        while (!mathOperations.IsInputValidDouble(input))
                        {
                            Console.WriteLine("Invalid input! Please try again.");
                            input = Console.ReadLine();
                        }
                        depth = Convert.ToDouble(input);

                        Console.WriteLine("Capacity is " + mathOperations.CalculateCapacity(height, width, depth));
                        break;

                    case "-h":

                        Console.WriteLine("-a : Calculate area of given measurements.");
                        Console.WriteLine("-b : Calculate capacity of given measurements.");
                        Console.WriteLine("-h : Print out all available arguments.");
                        break;

                    default:

                        Console.WriteLine("Unknown command line argument. Use -h to find out all valid arguments.");
                        break;
                }
            }
            Console.WriteLine("Finished. Updating run count to registry ..");
            Registry.SetValue(Constants.RegistryKey, Constants.GivenIntegerValue, runCount + 1);
            Console.WriteLine(".. Press any key to continue ..");
            Console.ReadLine();
        }
    }
}
