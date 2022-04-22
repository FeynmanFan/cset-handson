
using System.Linq.Expressions;

Console.WriteLine("Please enter an integer:");
var entry = Console.ReadLine();

int x;

while (!int.TryParse(entry, out x))
{
    Console.WriteLine("Please enter an integer:");
    entry = Console.ReadLine();
}

Console.WriteLine("TODO: Implement func");
return;

/*ConstantExpression xParameter = Expression.Constant(x);
ConstantExpression twelve = Expression.Constant(12);
Expression greaterThan = Expression.GreaterThan(xParameter, twelve);

var expr = Expression.Lambda<Func<bool>>(greaterThan);

var func = expr.Compile();
Console.WriteLine(x.ToString() + " is " + (func() ? "" : "not ") + "greater than 12");*/