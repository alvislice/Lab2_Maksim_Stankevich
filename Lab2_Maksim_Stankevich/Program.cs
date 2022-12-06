using System;

namespace Lab2_Maksim_Stankevich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number;
                Console.Clear();
                try
                {
                    Console.WriteLine("Input day nubmer");
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input data");
                    Console.ReadKey();
                    continue;
                }

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid input data");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
