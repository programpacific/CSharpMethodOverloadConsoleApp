
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
    class Program
    {
        static void Main(string[] args)
        {
            mathOperations math = new mathOperations();
            Console.Write("You're friend decided to go out to the bar, how many dollars did they have in their wallet? ");
            int yourMoney = Convert.ToInt32(Console.ReadLine());
            int leftOverMoney;

            math.partyTime(yourMoney, out leftOverMoney);

            Console.WriteLine("Surprise! It was a rough night for your friend, all they have left is ${0}!", leftOverMoney);
            Console.WriteLine("They were going to take you out for lunch, but.....");
            Console.WriteLine();

            Console.Write("We've decided to go hiking instead, for how many hours would you like to go hiking? ");

            int hikingTime = Convert.ToInt32(Console.ReadLine());

            // Static Class and Method
            Console.WriteLine("Congratulations! Your happiness level has increased to {0}!", goneHiking.yourHappiness(hikingTime));
            Console.WriteLine("Press enter to exit!");
            Console.ReadLine();


        }

    }
}












































            //Console.WriteLine("Please select the convertor direction");
            //Console.WriteLine("1. From Celsius to Fahrenheit.");
            //Console.WriteLine("2. From Fahrenheit to Celsius.");
            //Console.Write(":");

//string selection = Console.ReadLine();
//double F, C = 0;

//switch (selection)
//{
//    case "1":
//        Console.Write("Please enter the Celsius temperature: ");
//        F = NotGoingToTheBar.CelsiusToFahrenheit(Console.ReadLine());
//        Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
//        break;

//    case "2":
//        Console.Write("Please enter the Fahrenheit temperature: ");
//        C = NotGoingToTheBar.FahrenheitToCelsius(Console.ReadLine());
//        Console.WriteLine("Temperature in Celsius: {0:F2}", C);
//        break;

//    default:
//        Console.WriteLine("Please select a convertor.");
//        break;
//}

//// Keep the console window open in debug mode.
//Console.WriteLine("Press any key to exit.");
//Console.ReadKey();
