namespace Logical_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to get Reverse Number : ");
            int ReNum = Convert.ToInt32(Console.ReadLine());

            int Reverse = 0, rem;

            while (ReNum != 0)
            {
                rem = ReNum % 10;
                Reverse = (Reverse * 10) + rem;
                ReNum /= 10;
            }
            Console.WriteLine("Reverse Number is : " + Reverse);

        }

    }

}

