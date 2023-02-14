namespace LogicalProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, i, num;
            Console.WriteLine("Enter your Number to Check Prime number or not");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            for (i = 1; i <= num; i++)
            {

                if (num % i == 0)
                {
                    a++;

                }
            }
            if (a == 2)
            {
                Console.WriteLine("Prime number");

            }
            else
            {
                Console.WriteLine("Not Prime number");
            }
        }
    }
}
