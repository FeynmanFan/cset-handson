using System.Linq;

Console.Write("Please enter your number:");
var number = Console.ReadLine();

int x;

while(!int.TryParse(number, out x))
{
    Console.WriteLine("Please enter an integer value:");
    number = Console.ReadLine();
}

var square = SquareNumber(x);

Console.WriteLine($"The square of {x} is {square}");

int SquareNumber(int value)
{
    return value * value;
}