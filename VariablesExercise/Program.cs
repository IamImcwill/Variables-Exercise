namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Caris";
            int age = 42;
            char middleInitial = 'R';
            bool isOver18 = true;
            double currentTemp = 58;
            decimal currentPrice = 420.79m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");

        }
    }
}
