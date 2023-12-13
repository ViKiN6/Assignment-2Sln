using System.Security.Cryptography.X509Certificates;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConvertNumbers2Text.convert(value));
        }
             
    }
}
