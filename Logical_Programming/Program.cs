using System.Diagnostics;

namespace Logical_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine("Coupon Number is : " + result);
        }
    }

}


