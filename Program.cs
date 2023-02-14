using System.Diagnostics;

namespace LogicalProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A value for FabSeries :-");
            int fabS = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(fabS);
            int num1 = 0;
            int num2 = 1;
            int nextNum;
            if (fabS < 2)
            {
                Console.WriteLine("Enter a value greater than 2 if u want to see Fabseries :");
            }
            else
            {
                Console.Write(num1 + " " + num2 + " ");
                for (int i = 2; i < fabS; i++)
                {
                    nextNum = num1 + num2;
                    Console.Write(nextNum + " ");
                    num1 = num2;
                    num2 = nextNum;
                }
            }    
        }
    }
}
