namespace Logical_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Check Number is Prime or Not : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            for (int i = 2; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(Number + " is not Prime Number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine(Number + " is Prime Number");

            }
        }

    }

}

