namespace Algrithm
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number :");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the secound number :");
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the theird number :");
            float number3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the four number :");
            float number4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the five number :");
            float number5 = float.Parse(Console.ReadLine());

            float result = number1 + number2 + number3 + number4 + number5;
            Console.WriteLine("The result is :" +result);

            float avg = result / 5;
            Console.WriteLine("The avrage is :" + avg);
        }
    }
}
