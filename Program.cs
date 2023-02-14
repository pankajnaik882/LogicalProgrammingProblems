namespace LogicalProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Input the Starting range or number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Starting range or number");
            mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect Number within the given range : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                {
                    Console.WriteLine("{0}", n);
                }
            }
        }
    }
}
