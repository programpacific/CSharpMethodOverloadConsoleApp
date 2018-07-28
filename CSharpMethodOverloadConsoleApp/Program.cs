
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
    class Program
    {
        static void Main(string[] args)
        {
            ExampleMethods exampleMethods = new ExampleMethods();
            Console.Write("Your friend decided to go out to the bar, how many dollars did they have in their wallet? ");
            int yourMoney = Convert.ToInt32(Console.ReadLine());
            int leftOverMoney;

            exampleMethods.PartyTime(yourMoney, out leftOverMoney);

            Console.WriteLine("Surprise! It was a rough night for your friend, all they have left is ${0}!", leftOverMoney);
            Console.WriteLine("They were going to take you out for lunch, but.....");
            Console.WriteLine();

            Console.Write("We've decided to go hiking instead, for how many hours would you like to go hiking? ");

            int hikingTime = Convert.ToInt32(Console.ReadLine());

            // Static Class and Method
            Console.WriteLine("Congratulations! Your happiness level has increased to {0}!", GoneHiking.yourHappiness(hikingTime));
            Console.WriteLine();

            // Overloaded Method Example
            Console.WriteLine("Lastly we'll determine how many miles you hiked!");
            Console.WriteLine("To show an example of overloaded methods, I'll also convert your traveled distance into kilometers!");
            Console.WriteLine();
            Console.Write("What was your average hiking speed in miles per hour? ");
            int milesTraveled = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How many hours did you hike? ");
            int hoursTraveled = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            exampleMethods.DistanceCalc(hoursTraveled, milesTraveled, out double milesPerHr);
            exampleMethods.DistanceCalc( milesPerHr, out double kilometersPerHr);

            // To add injury to insult I used {0} for both of my placeholders and thought that my values were not being transferred correctly!
           // Tried rewriting a bit of the code and had it all click.... Dork! Have a nice day!

            Console.WriteLine("Wow you hiked {0} miles, that would equal {1} kilometers!!!", milesPerHr, kilometersPerHr);
            Console.WriteLine("Thank you for demoing my program, press enter to exit.");
            Console.ReadLine();
        }

    }
}