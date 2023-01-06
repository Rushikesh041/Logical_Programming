using System.Diagnostics;

namespace Logical_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number for how many times to print the statement to get time elapsed for it : ");
            int s = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Hello Rushikesh Jadhav");
            }
            stopWatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopWatch.Elapsed);
        }
    }

}


