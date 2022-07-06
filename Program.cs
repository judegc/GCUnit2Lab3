// Prompt the user to enter a number.  Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
string repeatInput = "";

do
{
    int sum = 0;
    Console.WriteLine("Hello, please enter a number:");
    int inputA = int.Parse(Console.ReadLine());

    for (int i = 0; i <= inputA; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
    Console.WriteLine("Would you like to continue? y/n:");
    repeatInput = Console.ReadLine();
} while (repeatInput.ToLower() == "y");
Console.WriteLine("Goodbye!");