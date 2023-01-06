namespace Logical_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Check Number is Perfect or Not : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == Number)
            {
                Console.WriteLine(Number + " is Perfect Number");

            }
            else 
            {
                Console.WriteLine(Number + " is Not Perfect Number");
            }
        }

    }

}

