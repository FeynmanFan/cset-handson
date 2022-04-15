namespace Exercises
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Calculate(int x, int y)
        {
            return Add(x, y);
        }

        public int Calculate(Func<int, int, int> func, int x, int y)
        {
            return func(x, y);
        }
    }
}