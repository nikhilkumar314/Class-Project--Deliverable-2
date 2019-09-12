using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project__Deliverable_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Loop
        Start:

            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement:"); //Writes first line to display
            
              // Using the try catch block to validate user input.

            
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will parse the string value to integer
                int inputvalue = int.Parse(input);

                {
                    //For Loop
                    for (int i = 1; i <= inputvalue; i++)
                    {
                        Console.WriteLine("You entered: " + input +"." + " " + "This is the current integer in the loop:" + " " + i );

                    }
                    Console.WriteLine("Enter another integer ...");
                    
                    goto Start; //Iterates back to start of code block 

                }
            } // End of try
            catch //Catches any errors the user inputs
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
            {

            }

            }
    }
    }
