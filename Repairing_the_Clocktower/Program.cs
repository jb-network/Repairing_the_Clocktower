// This is challenge work for the "C# Players Guide"
// Level 9 Repairing the Clocktower
//The challenge accepts input from the console
//It will display "Tick" if the number is even and "Tock" if the number is odd.

Console.WriteLine("Enter a number to repair the clock: ");
int userNumber = Convert.ToInt32(Console.ReadLine());


if (userNumber%2 == 0)
{
    Console.WriteLine("The number that you provide was even: Tick");
}
else
{
    Console.WriteLine("The number that you provide was odd: Tock");
}

Console.WriteLine("Press any key to end");
Console.ReadKey();