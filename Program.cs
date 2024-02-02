namespace Sequential_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Welcome to sequential digits app");
            Console.WriteLine("Enter your low number : ");
            int low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your high number : ");
            int high = Convert.ToInt32(Console.ReadLine());
            sequentialDigits sequentialDigits = new();
            List<int> digits = sequentialDigits.sequentiallist(low , high);
            string result = string.Join(",", digits);
            if(digits.Count!=0)
             Console.WriteLine($"Your sequential list between {low} and {high} is {result}");
            else
                Console.WriteLine("Something wrong...");

        }
    }
}
