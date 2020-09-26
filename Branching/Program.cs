using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter temperature:");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());
            int roomTemperature = 70;
            //SHORT-HAND CODE for IF ELSE STATEMENTS
            //example of TERINARY OPERATOR (condition and two choices) used in C# (NOTATION: if the condition ( code in parentheses ) is met/ or "true"  question mark (?) 
            //- followed by the action code for the evalutation of true - colon(:) 
            // - and the action code desired for if the evaluation was false
            string comparisonResult = currentTemperature == roomTemperature ? "It is room temperature." : "It is NOT room temperature.";
            Console.WriteLine(comparisonResult);
            Console.ReadLine();
        }
    }
}
//            if (currentTemperature == roomTemperature)
//            {
//                Console.WriteLine("It is exactly room tempeerature.");
//            }
//            else if (currentTemperature > roomTemperature)
//            {
//                Console.WriteLine("It is warmer than room temperature.");
//            }
//            else if (currentTemperature < roomTemperature)
//            {
//                Console.WriteLine("It is cooler than room temperature.");
//            }
//            else
//            {
//                Console.WriteLine("It is not exactly room temperature.");
//            }
//            Console.ReadLine();
//        }
//    }
//}