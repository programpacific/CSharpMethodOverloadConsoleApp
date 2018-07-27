
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
// 2. In the Main() method, instantiate that class.
// 3. Have the user enter a number.Call the method on that number.Display the output to the screen.
// It should be the entered number, divided by two.
// 4. Create a method with output parameters.
// 5. Overload a method.
// 6. Declare a class to be static.


namespace MethodExamples
{
    class ExampleMethods
    {
        public void partyTime(int yourMoney, out int leftOverMoney)
        {
            leftOverMoney = yourMoney / 2;
        }


        // Method With Output Parameters
        public void fuelCalc(int Miles, out double FuelCost, out string FuelComment)
        {
            FuelCost = Miles * 2.85;
            FuelComment = "Cost of fuel";
        }

        // Overloaded Method
        public void tripHours(int hoursTraveled, out int minutesTraveled, out string k)
        {
            minutesTraveled = hoursTraveled * 60;
            k = "Minutes Traveled.";
        }
    }
    public static class goneHiking
    {
        public static int yourHappiness(int HapinessIncreased)
        {
            return HapinessIncreased * 10;
        }
    }
}
