// BUV26 - Marcus Jungersten

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small = 10;
            int medium = 15;
            int large = 20;
            int totalCost = 0;
            bool buyMore = true;

            while (buyMore)
            {
                Console.WriteLine("Please select your coffee size:");
                Console.WriteLine("1 - Small");
                Console.WriteLine("2 - Medium");
                Console.WriteLine("3 - Large\n");

                bool isFormatCorrect = int.TryParse(Console.ReadLine(), out int selection);

                if (isFormatCorrect)
                {
                    // Add coffe cost to total cost
                    switch (selection)
                    {
                        case 1:
                            totalCost += small;
                            break;
                        case 2:
                            totalCost += medium;
                            break;
                        case 3:
                            totalCost += large;
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("Do you want to buy more coffee? y/n");
                    string userAnswer = Console.ReadLine()!.ToUpper();

                    if (userAnswer == "Y")
                    {
                        buyMore = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        buyMore = false;
                        Console.WriteLine();
                    }
                }
            }

            if (totalCost > 0)
            {
                Console.WriteLine("Thank you for you order!\n");
                Console.WriteLine("Total to pay: " + totalCost);
            }
            else
            {
                Console.WriteLine("Order cancelled");
            }
        }
    }
}
