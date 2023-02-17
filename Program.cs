namespace Program
{
    public class logical
    {
        public static void Main(string[] args)
        {
            int CurrentValue = 0;
            int LastValue=0;
            Console.WriteLine("how many coupon number you required ?");
            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("genreted coupon number");

            for (int i = 0; i < Number; i++)
            {
                Random number = new Random();
                int coupon = number.Next(10000, 100000);
                CurrentValue = coupon;

                Console.WriteLine("Coupon : " + coupon);
                Console.ReadLine();

                if (CurrentValue == LastValue)
                {
                    Console.WriteLine("Coupon already exist");
                }
                else
                {
                    Console.WriteLine("Coupon is Unique");
                }

                LastValue = CurrentValue;
            }
        }
    }
}
