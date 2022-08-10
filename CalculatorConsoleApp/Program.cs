namespace Calculations
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var calc = new Calculator();
            var names = new Names();

            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(names.DisplayFullName("maggie", "rivera"));
        }
    }
}