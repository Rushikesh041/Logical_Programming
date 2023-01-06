namespace Logical_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Elements : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int num1 = 0, num2 = 1, num3;

            Console.Write("Fibonacci Series is : ");
            for (int i = 1; i <= Number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}