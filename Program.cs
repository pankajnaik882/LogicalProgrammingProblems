namespace LogicalProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, reverse = 0, num, rem;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;

            }
            Console.WriteLine("Reversed Number " + reverse);
        }
    }
}
