namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            String name = "Mary";
            int appleNum = 7;
            char lastIntial = 'O';
            bool herBool = true;
            double herhours = 4;
            decimal applePrice = 2.99m;

            Console.WriteLine($"This is {name} She is selling {appleNum} apples. Her last intial is {lastIntial} and her stan is open for {herhours} " +
                $"she charges {applePrice} for each apple");
        }
    }
}
