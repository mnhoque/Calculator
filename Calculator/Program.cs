using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want ?");

            int.TryParse(Console.ReadLine(),out int number);

            switch (number)
            {
                case 1:
                    addNumbers();
                    break;
                case 2:
                    subtractNumbers();
                    break;
                case 3:
                    multiplicationNumbers();
                    break;
                case 4:
                    divisionNumbers();
                    break;
                default:
                    // code block
                    break;
            }

            Console.ReadKey();
        }

        public static double addNumbers()
        {
            var numbers = new List<double>();
            var sum = 0.0;
            Console.WriteLine("Enter your desired number");
            var firstNumber = double.Parse(Console.ReadLine());
            numbers.Add(firstNumber);

            ConsoleKeyInfo name = Console.ReadKey();
            while (name.KeyChar.ToString() == "+")
            
            {
                
                
                Console.WriteLine("Enter your desired another number");

                var secoundNumber = 0.0;
                double.TryParse(Console.ReadLine(), out secoundNumber);
                numbers.Add(secoundNumber);
                name = Console.ReadKey();
                secoundNumber = 0.0;
                if (name.KeyChar.ToString() == "=")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum = sum + numbers[i];
                        
                    }
                }

            }
            Console.WriteLine(sum);
            return sum;
        }

        public static int subtractNumbers()
        {
            int sum = 180;
            Console.WriteLine(sum);
            return 100;
        }

        public static int multiplicationNumbers()
        {
            int sum = 170;
            Console.WriteLine(sum);
            return 100;
        }

        public static int divisionNumbers()
        {
            int sum = 10;
            Console.WriteLine(sum);
            return 100;
        }
    }
}
