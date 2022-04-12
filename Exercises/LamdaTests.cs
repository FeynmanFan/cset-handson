namespace Exercises
{
    public class LambdaTests
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Calculate(int x, int y)
        {
            return Add(x, y);
        }
    }
}