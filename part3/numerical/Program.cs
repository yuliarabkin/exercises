
namespace numerical
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 1234567;
            NumericalExpression numericalExpression = new NumericalExpression(num);
            Console.WriteLine(numericalExpression.ToString());
            

        }
    }
}
