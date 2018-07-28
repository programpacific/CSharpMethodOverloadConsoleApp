
using System;



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
        public void PartyTime(int yourMoney, out int leftOverMoney)
        {
            leftOverMoney = yourMoney / 2;
        }


        // Method With Output Parameters
        public void FuelCalc(int Miles, out double FuelCost, out string FuelComment)
        {
            FuelCost = Miles * 2.85;
            FuelComment = "Cost of fuel";
        }


        // Overloaded Method - Not sure what the heck I was doing on my first try! This hopefully looks a little better!!!
        public void DistanceCalc(double hoursTraveled, double milesTraveled, out double effectiveImperialSpeed)
        {

            effectiveImperialSpeed = milesTraveled * hoursTraveled;
        }

        public void DistanceCalc(double effectiveImperialSpeed, out double effectiveMetricDistance)
        {

            effectiveMetricDistance = effectiveImperialSpeed * 1.609;
        }

    }

    public static class GoneHiking
    {
        public static int yourHappiness(int HapinessIncreased)
        {
            return HapinessIncreased * 10;
        }
    }
}
