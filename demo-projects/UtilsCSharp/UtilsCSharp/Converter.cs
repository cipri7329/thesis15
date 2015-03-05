using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsCSharp
{
    public class ConverterUtils
    {

        public static int convertStringToInt(string number)
        {
            int numVal = 0;
            // ToInt32 can throw FormatException or OverflowException. 
            try
            {
                numVal = Convert.ToInt32(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }
            finally
            {
                if (numVal < Int32.MaxValue)
                {
                    Console.WriteLine("The new value is {0}", numVal + 1);
                }
                else
                {
                    Console.WriteLine("numVal cannot be incremented beyond its current value");
                }
            }

            return numVal;
        }

    }
}
